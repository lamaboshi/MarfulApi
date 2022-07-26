namespace MarfulApi.Model
{
    public class Post
    {
        public int Id { set; get; }
        public string? Description { set; get; }
        public byte[]? Image { set; get; }
        public DateTime? dateTime { set; get; }
        public int? BrandId { set; get; }
        public virtual Brand? Brand { set; get; }
        public int? JobId { set; get; }
        public virtual Job? Job { set; get; }
        public int? InfulonserId { set; get; }
        public virtual Infulonser? Infulonser { set; get; }
        public virtual ICollection<UserPost>? UserPost { set; get; }
        public virtual ICollection<InfulonserPost>? InfulonserPost { set; get; }
    }
}
