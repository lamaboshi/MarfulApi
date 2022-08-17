using MarfulApi.Model;
using MarfulApi.Dto;

namespace MarfulApi.Infrastructure
{
    public interface ICompany
    {
        public Company GetCompany(int id);
        public IQueryable<Company> GetCompanys { get; }
        public List<Post> GetAllCompanyPost(int Id);
        public Company getCompanyByBrandId(int IdBrand);
        public List<Brand> GetCompanyBrand(int id);
        public void Save(Company company);
        public void Update(Company company);
        public void Delete(int id);
        public bool IsExisting(string email);
        public void ChangePassword(int Id, string password);
        public double GetFollowersCount(string email);
        public List<object> GetFollowers(string email);
        public CompanyWebDto GetCompanyAll(string email); 
    }
}
