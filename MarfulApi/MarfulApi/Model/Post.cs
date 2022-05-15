namespace MarfulApi.Model
{
    public class Post
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public byte[] Image { set; get; }
        public int IdBrand { set; get; }
        public Brand Brand { set; get; }
        public int IdInfulonser { set; get; }
        public Infulonser Infulonser { set; get; }
        public int IdJob { set; get; }
        public Job Job { set; get; }
        ICollection<UserPost> UserPost { set; get; }
    }
}
