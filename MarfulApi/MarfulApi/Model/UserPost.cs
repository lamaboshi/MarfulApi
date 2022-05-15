namespace MarfulApi.Model
{
    public class UserPost
    {
        public int Id { set; get; }
        public bool InterAction { set; get; }
        public int IdUser { set; get; }
        public User User { set; get; }
        public int IdPost { set; get; }
        public Post Post { set; get; }
        ICollection<Basket> Basket { set; get; }
    }
}
