namespace MarfulApi.Model
{
    public class UserPost
    {
        public int Id { set; get; }
        public bool InterAction { set; get; }
        public int UserId { set; get; }
        public User User { set; get; }
        public int PostId { set; get; }
        public Post Post { set; get; }
        public ICollection<Basket> Basket { set; get; }
    }
}
