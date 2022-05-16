namespace MarfulApi.Model
{
    public class Basket
    {
        public int Id { set; get; }
        public int PostId { set; get; }
        public Post Post { set; get; }

    }
}
