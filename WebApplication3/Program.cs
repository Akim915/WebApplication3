using WebApplication3;
using WebApplication3;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ChatHistory chatHistory = new ChatHistory();
chatHistory.AddMessage(new ChatMessage("User", "Hello!"));
chatHistory.AddMessage(new ChatMessage("Bot", "Hi there! How can I assist you "));
chatHistory.AddMessage(new ChatMessage("User", "Can you tell me a joke?"));


app.MapGet("/", () => "Hello World!");


app.MapGet("/chat", (DateTime? timestamp) =>
{
    if (timestamp == null)
        return chatHistory.GetLast(10);
    return chatHistory.GetMessagesAfter(timestamp ?? DateTime.Now);
});

app.Run();