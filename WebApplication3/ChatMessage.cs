namespace WebApplication3
{
    public class ChatMessage
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public ChatMessage(string author, string content)
        {
            Author = author;
            Content = content;
            Timestamp = DateTime.Now;
        }
    }
}