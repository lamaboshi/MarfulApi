namespace MarfulApi.Model
{
    public class Brand
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public byte[]? Image { set; get; }
        public int? InfulonserId { set; get; }
        public virtual Infulonser Infulonser { set; get; }
        public int CompanyContentId { set; get; }
        public virtual CompanyContent CompanyContent { set; get; }
        public virtual ICollection<Product> Product { set; get; }
        public virtual ICollection<Post> Post { set; get; }


    }
}
