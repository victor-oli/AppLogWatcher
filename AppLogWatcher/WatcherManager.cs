using System;
using System.Configuration;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace AppLogWatcher
{
    public class WatcherManager
    {
        private static TelegramBotClient botClient;
        private static string[] toSendMessages;

        public WatcherManager()
        { 
            botClient = new TelegramBotClient(ConfigurationManager.AppSettings["TelegramBotToken"]);
            toSendMessages = ConfigurationManager.AppSettings["ToSendMessages"].Split('/');
        }

        public void SendMessage(string message, string appName = "N/A")
        {
            if (string.IsNullOrWhiteSpace(appName))
                appName = "N/A";

            toSendMessages = ConfigurationManager.AppSettings["ToSendMessages"].Split('/');

            for (int i = 0; i < toSendMessages.Length; i++)
            {
                var temp = botClient.SendTextMessageAsync(toSendMessages[i], $"App: {appName} - {message}", parseMode: ParseMode.Markdown).Result;
            }
        }

        public void SendMessage(Exception ex, string appName = "N/A")
        {
            SendMessage($"{ex.Message.ToUpper()} -```{ex.StackTrace}```", appName);
        }
    }
}