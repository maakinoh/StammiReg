using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.StammiReg.Bot.Session;

public interface StateHandler
{
    public StateHandler OnMessage(ITelegramBotClient client, Update update);
}