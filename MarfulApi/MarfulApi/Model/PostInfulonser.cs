namespace MarfulApi.Model
{
    public class PostInfulonser
    {
        public int Id { get; set; }
        public bool Interaction { get; set; }
        public int InfulonserId { get; set; }
        public virtual Infulonser? Infulonser { get; set; }
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
    }
}
