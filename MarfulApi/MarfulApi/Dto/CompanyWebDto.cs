using MarfulApi.Model;
namespace MarfulApi.Dto
{
    public class CompanyWebDto
    {
       public Company company { set; get; }
        public List<CompanyContent> CompanyContents { set; get; }
        public List<Brand> Brands { set; get; }
        public List<Product> products { set; get; }
    }
}
