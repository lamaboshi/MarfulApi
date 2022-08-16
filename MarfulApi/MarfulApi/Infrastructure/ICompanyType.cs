using MarfulApi.Model;
namespace MarfulApi.Infrastructure
{
    public interface ICompanyType
    {
        public CompanyType GetCompanyType(int id);
        public IQueryable<CompanyType> GetCompanyTypes { get; }
        public void Save(CompanyType companyType);
        public void Delete(int id);
        public void Update(CompanyType companyType);
        public CompanyType IsExisting(string Type, string Password);
    }
}
