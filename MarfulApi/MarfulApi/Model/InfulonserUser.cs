namespace MarfulApi.Model
{
    public class InfulonserUser
    {
        public int Id { set; get; }
        public int? InfulonserId { set; get; }
        public virtual Infulonser? Infulonser { set; get; }
        public int? UserId { set; get; }
        public virtual User? User { set; get; }
    }
}
