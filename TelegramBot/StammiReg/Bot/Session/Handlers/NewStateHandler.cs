using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.StammiReg.Bot.Session.Handlers;

public class NewStateHandler : IStateHandler
{
    public IStateHandler OnMessage(ITelegramBotClient client, Message message)
    {
        throw new NotImplementedException();
    }


    public IStateHandler OnCallback(ITelegramBotClient client, CallbackQuery callbackQuery)
    {
        throw new NotImplementedException();
    }
}