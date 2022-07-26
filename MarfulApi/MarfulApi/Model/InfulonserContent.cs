namespace MarfulApi.Model
{
    public class InfulonserContent
    {
        public int Id { set; get; }
        public int? InfulonserId { set; get; }
        public virtual Infulonser? Infulonser { set; get; }
        public int? ContentId { set; get; }
        public virtual Content? Content { set; get; }

    }
}
