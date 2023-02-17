﻿using Telegram.Bot.Types;
using XinjingdailyBot.Model.Models;

namespace XinjingdailyBot.Interface.Data
{
    public interface IDialogueService : IBaseService<Dialogue>
    {
        Task RecordUpdate(Update update);
    }
}
