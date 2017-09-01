Adicionar essas Tags no .config.
- TelegramBotToken: É o token do seu bot.
- ToSendMessages: A segunda são os chatids que você quer que as mensagens sejam enviadas.

```
    <add key="TelegramBotToken" value="token_do_bot" />
    
    // para adicionar mais de um chatid, é só separar com o caracter '/'. exemplo: 123/456/789
    <add key="ToSendMessages" value="chatids" />
```


Exemplo de uso:

```
    // envio de mensagem de texto
    new WatcherManager().SendMessage("sua mensagem", "nome da sua aplicação");
    
    // envio de exception
    new WatcherManager().SendMessage(ex, "nome da sua aplicação");
```
