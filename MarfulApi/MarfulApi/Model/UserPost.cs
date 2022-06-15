namespace MarfulApi.Model
{
    public class UserPost
    {
        public int Id { set; get; }
        public bool InterAction { set; get; }
        public int UserId { set; get; }
        public virtual User? User { set; get; }
        public int PostId { set; get; }
        public virtual Post? Post { set; get; }
        public virtual ICollection<Basket>? Basket { set; get; }
    }
}
