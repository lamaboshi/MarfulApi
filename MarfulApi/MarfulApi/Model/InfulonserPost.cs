namespace MarfulApi.Model
{
    public class InfulonserPost
    {
        public int Id { set; get; }
        public int IdInfulonser { set; get; }
        public Infulonser Infulonser { set; get; }
        public int IdPost { set; get; }
        public Post Post { set; get; }
    }
}
