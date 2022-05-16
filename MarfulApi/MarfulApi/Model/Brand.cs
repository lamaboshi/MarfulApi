namespace MarfulApi.Model
{
    public class Brand
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int InfulonserId { set; get; }
        public Infulonser Infulonser { set; get; }
        public int CompanyContentId { set; get; }
        public CompanyContent CompanyContent { set; get; }
        public ICollection<Product> Product { set; get; }
        public ICollection<Post> Post { set; get; }


    }
}
