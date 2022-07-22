﻿using System.Diagnostics;
using Telegram.Bot;
using Telegram.Bot.Types;
using XinjingdailyBot.Helpers;
using XinjingdailyBot.Models;
using static XinjingdailyBot.Utils;

namespace XinjingdailyBot.Handlers.Messages.Commands
{
    internal static class SuperCmd
    {
        /// <summary>
        /// 设置用户组
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="dbUser"></param>
        /// <param name="message"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        internal static async Task<string> SetUserGroup(ITelegramBotClient botClient, Users dbUser, Message message, string[]? args)
        {
            long? targetUserId = null;
            if (message.ReplyToMessage != null)
            {

                User? user = message.ReplyToMessage.From;
                if (user != null)
                {
                    if (user.IsBot)
                    {
                        if (user.Id == BotID)
                        {

                        }
                    }
                    targetUserId = user.Id;
                }
            }
            else
            {
                if (args != null)
                {
                    foreach (string arg in args)
                    {
                        if (arg.StartsWith('@'))
                        {
                            string userName = arg[1..];

                            Users? user = await DB.Queryable<Users>().FirstAsync(x => x.UserName == userName);

                            if (user != null)
                            {
                                targetUserId = user.UserID;
                                break;
                            }
                        }
                        else
                        {
                            if (long.TryParse(arg, out var uid))
                            {
                                targetUserId = uid;
                                break;
                            }
                        }
                    }
                }
            }

            if (targetUserId == null)
            {
                return "找不到目标用户";
            }

            var keyboard = MarkupHelper.SetUserGroupKeyboard();
            var msg = await botClient.SendTextMessageAsync(message.Chat.Id, "请选择用户组", replyMarkup: keyboard, replyToMessageId: message.MessageId, allowSendingWithoutReply: true);

            CmdActions record = new()
            {
                ChatID = msg.Chat.Id,
                MessageID = msg.MessageId,
                OperatorUID = dbUser.UserID,
                Command = "SETGROUP",
                TargetUserID = (long)targetUserId,
            };

            await DB.Insertable(record).ExecuteCommandAsync();

            return "";
        }

        /// <summary>
        /// 机器人重启
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="dbUser"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        internal static async Task<string> ResponseRestart(ITelegramBotClient botClient, Users dbUser, Message message)
        {
            CmdActions record = new()
            {
                ChatID = message.Chat.Id,
                MessageID = message.MessageId,
                OperatorUID = dbUser.UserID,
                Command = "RESTART",
            };

            await DB.Insertable(record).ExecuteCommandAsync();

            _ = Task.Run(async () =>
            {
                try
                {
                    Process.Start(Environment.ProcessPath!);
                }
                catch (Exception ex)
                {
                    Logger.Error(ex);
                }

                await Task.Delay(2000);

                Environment.Exit(0);
            });

            return "Bot即将重启";
        }

    }
}
