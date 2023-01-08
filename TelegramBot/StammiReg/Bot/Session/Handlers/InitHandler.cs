using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.StammiReg.Bot.Session.Handlers;

public class InitHandler : IStateHandler
{

    public IStateHandler OnMessage(ITelegramBotClient client, Message message)
    {
        if (message.SenderChat?.Id.ToString() == Environment.GetEnvironmentVariable("STAMMIREG-ADMIN-TGID"))
            return new AdminHandler();
        return this;
    }
}