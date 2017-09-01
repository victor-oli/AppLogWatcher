Adicionar essas Tags no .config.
- TelegramBotToken: É o token do seu bot.
- ToSendMessages: A segunda são os chatids que você quer que as mensagens sejam enviadas.


Exemplo de uso:

```
    <add key="TelegramBotToken" value="351580461:AAGm5jqrQ5pO42vjp5NwHft4H66nAZZG8JE" />
    <add key="ToSendMessages" value="-166737837" />
```

```
    // envio de mensagem de texto
    new WatcherManager().SendMessage("sua mensagem", "nome da sua aplicação");
    
    // envio de exception
    new WatcherManager().SendMessage(ex, "nome da sua aplicação");
```
