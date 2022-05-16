namespace MarfulApi.Model
{
    public class InfulonserContent
    {
        public int Id { set; get; }
        public int InfulonserId { set; get; }
        public Infulonser Infulonser { set; get; }
        public int ContentId { set; get; }
        public Content Content { set; get; }

    }
}
