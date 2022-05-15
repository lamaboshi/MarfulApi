namespace MarfulApi.Model
{
    public class Message
    {
        public int Id { set; get; }
        public string Text { set; get; }
        public DateTime SendTime { set; get; }
        public int IdConversation { set; get; }
        public Conversation Conversation { set; get; }
        public int IdJob { set; get; }
        public Job Job { set; get; }
    }
}
