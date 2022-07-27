using MarfulApi.Model;
namespace MarfulApi.Infrastructure
{
    public interface ISearch
    {
        public List<object> Search(string search);
        public List<Infulonser> SearchInfulonser(string search);
        public List<Company> SearchCompany(string search);
        public List<Brand> SearchBrand(string search);
        public List<Product> SearchProduct(string search);
        public List<Content> SearchContent(string search);
    }
}
