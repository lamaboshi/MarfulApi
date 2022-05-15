namespace MarfulApi.Model
{
    public class Brand
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int IdInfulonser { set; get; }
        public Infulonser Infulonser { set; get; }
        public int IdCompanyContent { set; get; }
        public CompanyContent CompanyContent { set; get; }
        ICollection<Product> Product { set; get; }
        ICollection<Post> Post { set; get; }


    }
}
