using MarfulApi.Model;
namespace MarfulApi.Infrastructure
{
    public interface ICompanyInfulonser
    {
        public CompanyInfulonser GetInfulonserCompany(int id);
        public IQueryable<CompanyInfulonser> GetInfulonserCompanies { get; }
        public void Save(CompanyInfulonser infulonserCompany);
        public void Delete(int id);
        public void Update(CompanyInfulonser infulonserCompany);
    }
}
