namespace MarfulApi.Model
{
    public class Product
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public string? Description { set; get; }
        public byte[]? Image { set; get; }
        public string? Code { set; get; }
        public int BrandId { set; get; }

        public virtual Brand? Brand { set; get; }
        public virtual ICollection<Basket>? Baskets { get; set; }
    }
}
