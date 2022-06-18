using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface ICompany
    {
        public Company GetCompany(int id);
        public IQueryable<Company> GetCompanys { get; }
        public void Save(Company company);
        public void Update(Company company);
        public void Delete(int id);
        public bool IsExisting(string email);
    }
}
