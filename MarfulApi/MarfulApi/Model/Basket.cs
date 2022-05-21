namespace MarfulApi.Model
{
    public class Basket
    {
        public int Id { set; get; }
        public double TotalPrice { get; set; }
        public int ProductId { set; get; }
        public Product Product { set; get; }
        public int UserPostId { set; get; }
        public UserPost UserPost { set; get; }
    }
}
