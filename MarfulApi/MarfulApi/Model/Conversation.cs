namespace MarfulApi.Model
{
    public class Conversation
    {
        public int Id { set; get; }
        public DateTime Start { set; get; }
        public int CompanyId { set; get; }
        public Company Company { set; get; }
        public int InfulonserId { set; get; }
        public Infulonser Infulonser { set; get; }
        public ICollection<Message> Message { set; get; }
    }
}
