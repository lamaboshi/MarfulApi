using MarfulApi.Model;
namespace MarfulApi.Infrastructure
{
    public interface IInfulonserCompany
    {
        public InfulonserCompany GetInfulonserCompany(int id);
        public IQueryable<InfulonserCompany> GetInfulonserCompanies { get; }
        public void Save(InfulonserCompany infulonserCompany);
        public void Delete(int id);
        public void Update(InfulonserCompany infulonserCompany);
    }
}
