namespace MarfulApi.Model
{
    public class InfulonserUser
    {
        public int Id { set; get; }
        public int InfulonserId { set; get; }
        public Infulonser Infulonser { set; get; }
        public int UserId { set; get; }
        public User User { set; get; }
    }
}
