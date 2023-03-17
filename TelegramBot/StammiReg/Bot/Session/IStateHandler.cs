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
    public IStateHandler OnStateEnter<T>(ITelegramBotClient client, IStateHandler previousState)
    {
        return this;
    }

    /// <summary>
    /// This Method is called when a user revives a new message 
    /// </summary>
    /// <param name="client">The telegram bot client to interact with the Telegram-Bot-API</param>
    /// <param name="message">The message object of the message the user has revieved</param>
    /// <returns></returns>
    public IStateHandler OnMessage(ITelegramBotClient client, Message message);

    /// <summary>
    /// This Method is called when a user revived a callback query
    /// </summary>
    /// <param name="client"></param>
    /// <param name="callbackQuery"></param>
    /// <returns></returns>
    public IStateHandler OnCallback(ITelegramBotClient client, CallbackQuery callbackQuery)
    {
        return this;
    }

}