namespace MarfulApi.Model
{
    public class Message
    {
        public int Id { set; get; }
        public string Text { set; get; }
        public DateTime SendTime { set; get; }
        public int JobId { set; get; }
        public virtual Job? Job { set; get; }
        public int ConversationId { set; get; }
        public virtual Conversation? Conversation { set; get; }
    }
}
