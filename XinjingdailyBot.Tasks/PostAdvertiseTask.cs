using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Telegram.Bot;
using Telegram.Bot.Types;
using XinjingdailyBot.Infrastructure.Attribute;
using XinjingdailyBot.Infrastructure.Enums;
using XinjingdailyBot.Interface.Bot.Common;
using XinjingdailyBot.Interface.Data;
using XinjingdailyBot.Model.Models;

namespace XinjingdailyBot.Tasks;

/// <summary>
/// 发布广告
/// </summary>
[Job("0 0 9 * * ?")]
internal class PostAdvertiseTask : IJob
{
    private readonly ILogger<PostAdvertiseTask> _logger;
    private readonly IServiceProvider _serviceProvider;
    private readonly ITelegramBotClient _botClient;
    private readonly IAdvertiseService _advertisesService;
    private readonly IAdvertisePostService _advertisePostService;

    public PostAdvertiseTask(
        ILogger<PostAdvertiseTask> logger,
        IServiceProvider serviceProvider,
        ITelegramBotClient botClient,
        IAdvertiseService advertisesService,
        IAdvertisePostService advertisePostService)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
        _botClient = botClient;
        _advertisesService = advertisesService;
        _advertisePostService = advertisePostService;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        _logger.LogInformation("开始定时任务, 发布广告");

        var ad = await _advertisesService.GetPostableAdvertise();

        if (ad == null)
        {
            return;
        }

        var channelService = _serviceProvider.GetService<IChannelService>();

        if (channelService == null)
        {
            _logger.LogError("获取服务 {type} 失败", nameof(IChannelService));
            return;
        }

        var operates = new List<(EAdMode, ChatId)>
        {
           new (EAdMode.AcceptChannel, channelService.AcceptChannel),
           new (EAdMode.RejectChannel, channelService.RejectChannel),
           new (EAdMode.ReviewGroup, channelService.ReviewGroup),
           new (EAdMode.CommentGroup, channelService.CommentGroup),
           new (EAdMode.SubGroup, channelService.SubGroup),
        };

        foreach (var (mode, chat) in operates)
        {
            if (ad.Mode.HasFlag(mode) && chat.Identifier != null)
            {
                var chatId = chat.Identifier.Value;
                try
                {
                    var isFirst = await _advertisePostService.IsFirstAdPost(ad);

                    var msgId = await _botClient.CopyMessageAsync(chatId, ad.ChatID, (int)ad.MessageID, disableNotification: true);

                    //删除旧的广告
                    await _advertisePostService.DeleteOldAdPosts(ad, chatId, true);

                    var adpost = new AdvertisePosts {
                        AdId = ad.Id,
                        ChatID = chatId,
                        MessageID = msgId.Id,
                        Pined = ad.PinMessage && isFirst,
                        CreateAt = DateTime.Now,
                        ModifyAt = DateTime.Now,
                    };

                    await _advertisePostService.Insertable(adpost).ExecuteCommandAsync();

                    ad.ShowCount++;
                    ad.LastPostAt = DateTime.Now;

                    if (adpost.Pined)
                    {
                        await _botClient.PinChatMessageAsync(chatId, msgId.Id, true);
                    }

                    await _advertisesService.Updateable(ad).UpdateColumns(static x => new {
                        x.ShowCount, x.LastPostAt
                    }).ExecuteCommandAsync();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "投放广告出错");
                }
                finally
                {
                    await Task.Delay(500);
                }
            }
        }
    }
}
