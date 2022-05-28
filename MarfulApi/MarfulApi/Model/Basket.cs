namespace MarfulApi.Model
{
    public class Basket
    {
        public int Id { set; get; }
        public double TotalPrice { get; set; }
        public int ProductId { set; get; }
        public virtual Product Product { set; get; }
        public int UserPostId { set; get; }
        public virtual UserPost UserPost { set; get; }
    }
}
