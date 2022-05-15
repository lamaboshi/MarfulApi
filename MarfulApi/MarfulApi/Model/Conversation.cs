namespace MarfulApi.Model
{
    public class Conversation
    {
        public int Id { set; get; }
        public DateTime Start { set; get; }
        public int IdCompany { set; get; }
        public Company Company { set; get; }
        public int IdInfulonser { set; get; }
        public Infulonser Infulonser { set; get; }
        ICollection<Message> Message { set; get; }
    }
}
