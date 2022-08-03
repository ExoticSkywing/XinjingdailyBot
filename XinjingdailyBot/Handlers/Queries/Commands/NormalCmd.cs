﻿using Telegram.Bot;
using Telegram.Bot.Types;
using XinjingdailyBot.Helpers;
using XinjingdailyBot.Models;

namespace XinjingdailyBot.Handlers.Queries.Commands
{
    internal static class NormalCmd
    {

        /// <summary>
        /// 显示命令回复
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="dbUser"></param>
        /// <param name="callbackQuery"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        internal static async Task ResponseSay(ITelegramBotClient botClient, Users dbUser, CallbackQuery callbackQuery, string[] args)
        {
            string exec()
            {
                if (args.Length < 2)
                {
                    return "参数有误";
                }
                return string.Join(' ', args[1..]);
            }
            string text = exec();
            await botClient.AutoReplyAsync(text, callbackQuery);
        }

        /// <summary>
        /// 取消命令
        /// </summary>
        /// <param name="botClient"></param>
        /// <param name="dbUser"></param>
        /// <param name="callbackQuery"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        internal static async Task ResponseCancel(ITelegramBotClient botClient, Users dbUser, CallbackQuery callbackQuery, string[] args)
        {
            await botClient.AutoReplyAsync("操作已取消", callbackQuery);
            await botClient.EditMessageTextAsync(callbackQuery.Message!, "操作已取消", replyMarkup: null);
        }
    }
}
