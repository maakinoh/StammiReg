using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.StammiReg.Bot.Session.Handlers;

public class InitHandler : StateHandler
{
    public StateHandler OnMessage(ITelegramBotClient client, Update update)
    {
        if (update.Message.SenderChat?.Id.ToString() == Environment.GetEnvironmentVariable("STAMMIREG-ADMIN-TGID"))
            return new AdminHandler();
        return this;
    }
}