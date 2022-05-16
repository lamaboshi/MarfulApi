namespace MarfulApi.Model
{
    public class Post
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public byte[] Image { set; get; }
        public int BrandId { set; get; }
        public Brand Brand { set; get; }
        public ICollection<UserPost> UserPost { set; get; }
    }
}
