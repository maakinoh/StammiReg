using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.StammiReg.Bot;

public class Bot
{
    private const string TOKEN_ENV_NAME = "STAMMIREG-TOKEN";
    private readonly TelegramBotClient bot;


    public Bot()
    {
        bot = new TelegramBotClient(Environment.GetEnvironmentVariable(TOKEN_ENV_NAME) ??
                                    throw new InvalidOperationException("Telegram bot token is missing"));

        bot.StartReceiving(
            HandleUpdateAsync,
            HandlePollingErrorAsync
        );
    }


    private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update,
        CancellationToken cancellationToken)
    {  
        if (update.Message is not { } message)
            return;
        // Only process text messages
        if (message.Text is not { } messageText)
            return;

        switch (messageText)
        {
            case "/admin":
                break;
            case "/newMeet":
                break;
            case "/register":
                break;
            
        }
    }

    private Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception,
        CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}