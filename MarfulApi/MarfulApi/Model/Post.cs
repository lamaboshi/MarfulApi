namespace MarfulApi.Model
{
    public class Post
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public string? Image { set; get; }
        public int BrandId { set; get; }
        public Brand Brand { set; get; }
        public int JobId { set; get; }
        public Job Job { set; get; }
        public int InfulonserId { set; get; }
        public Infulonser Infulonser { set; get; }
        public ICollection<UserPost> UserPost { set; get; }
    }
}
