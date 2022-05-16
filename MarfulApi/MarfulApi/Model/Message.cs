namespace MarfulApi.Model
{
    public class Message
    {
        public int Id { set; get; }
        public string Text { set; get; }
        public DateTime SendTime { set; get; }
        public int ConversationId { set; get; }
        public Conversation Conversation { set; get; }
    }
}
