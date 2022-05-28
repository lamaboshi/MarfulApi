namespace MarfulApi.Model
{
    public class Conversation
    {
        public int Id { set; get; }
        public DateTime Start { set; get; }
        public int CompanyId { set; get; }
        public virtual Company Company { set; get; }
        public int InfulonserId { set; get; }
        public virtual Infulonser Infulonser { set; get; }
        public virtual ICollection<Message> Message { set; get; }
    }
}
