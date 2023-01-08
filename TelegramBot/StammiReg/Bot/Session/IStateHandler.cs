using Telegram.Bot;
using Telegram.Bot.Types;
using TelegramBot.StammiReg.Bot.Session.Handlers;

namespace TelegramBot.StammiReg.Bot.Session;

public interface IStateHandler
{
    /// <summary>
    /// This method is optional but can be implemented to handle, when a user enters a new state
    /// </summary>
    /// <param name="client">The telegram bot client to interact with the Telegram-Bot-API</param>
    /// <param name="previousState">The previous state. When no previous was found <see cref="InitHandler"/> will be used.</param>
    /// <returns></returns>
    public IStateHandler OnStateEnter(ITelegramBotClient client, IStateHandler previousState)
    {
        return this;
    }
    public IStateHandler OnMessage(ITelegramBotClient client, Message update);
}