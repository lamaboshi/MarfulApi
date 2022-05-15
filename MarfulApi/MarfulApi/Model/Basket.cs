namespace MarfulApi.Model
{
    public class Basket
    {
        public int Id { set; get; }
        public int IdProduct  { set; get; }   
        public Product Product { set; get; }
        public int IdPost { set; get; }
        public Post Post { set; get; }

    }
}
