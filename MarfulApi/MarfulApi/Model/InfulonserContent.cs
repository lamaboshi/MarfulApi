namespace MarfulApi.Model
{
    public class InfulonserContent
    {
        public int Id { set; get; }
        public int IdInfulonser { set; get; }
        public Infulonser Infulonser { set; get; }
        public int IdContent { set; get; }
        public Content Content { set; get; }

    }
}
