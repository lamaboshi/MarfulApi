using MarfulApi.Model;
using MarfulApi.Infrastructure;
namespace MarfulApi.Data
{
    public class InfulonserCompanyRepo:IInfulonserCompany
    {
        public readonly MarfulDbContext _db;
        public InfulonserCompanyRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<InfulonserCompany> GetInfulonserCompanies => _db.InfulonserCompanies;
        public void Delete(int id)
        {
            var infulonserCompany = _db.InfulonserCompanies.First(p => p.Id == id);
            if (infulonserCompany != null)
            {
                _db.InfulonserCompanies.Remove(infulonserCompany);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();

        }
        public InfulonserCompany GetInfulonserCompany(int id)
        {
            var infulonserCompany = _db.InfulonserCompanies.First(p => p.Id == id);
            if (infulonserCompany != null)
                return infulonserCompany;
            else
                throw new NotImplementedException();
        }
        public void Save(InfulonserCompany infulonserCompany)
        {
            if (infulonserCompany.Id == 0)
            {
                _db.InfulonserCompanies.Add(infulonserCompany);
                _db.SaveChanges();
            }

        }
        public void Update(InfulonserCompany infulonserCompany)
        {
            var InfulonserCompany = _db.InfulonserCompanies.First(p => p.Id == infulonserCompany.Id);
            if (InfulonserCompany != null)
            {
                InfulonserCompany.IdCompany = infulonserCompany.IdCompany;
                InfulonserCompany.IdInfulonser = infulonserCompany.IdInfulonser;
                InfulonserCompany.Followed = infulonserCompany.Followed;
                _db.SaveChanges();
            }
        }
    }
}
