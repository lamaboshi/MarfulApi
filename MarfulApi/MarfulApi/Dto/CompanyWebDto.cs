using MarfulApi.Model;
namespace MarfulApi.Dto
{
    public class CompanyWebDto
    {
       public Company company { set; get; }
       public List<Product> products { set; get; }
    }
}
