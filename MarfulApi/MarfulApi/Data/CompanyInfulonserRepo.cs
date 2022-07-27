using MarfulApi.Model;
using MarfulApi.Infrastructure;
namespace MarfulApi.Data
{
    public class CompanyInfulonserRepo : ICompanyInfulonser
    {
        public readonly MarfulDbContext _db;
        public CompanyInfulonserRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<CompanyInfulonser> GetInfulonserCompanies => _db.CompanyInfulonsers;
        public void Delete(int id)
        {
            var infulonserCompany = _db.CompanyInfulonsers.First(p => p.Id == id);
            if (infulonserCompany != null)
            {
                _db.CompanyInfulonsers.Remove(infulonserCompany);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();

        }
        public CompanyInfulonser GetInfulonserCompany(int id)
        {
            var infulonserCompany = _db.CompanyInfulonsers.First(p => p.Id == id);
            if (infulonserCompany != null)
                return infulonserCompany;
            else
                throw new NotImplementedException();
        }
        public void Save(CompanyInfulonser infulonserCompany)
        {
            if (infulonserCompany.Id == 0)
            {
                _db.CompanyInfulonsers.Add(infulonserCompany);
                _db.SaveChanges();
            }

        }
        public void Update(CompanyInfulonser infulonserCompany)
        {
            var InfulonserCompany = _db.CompanyInfulonsers.First(p => p.Id == infulonserCompany.Id);
            if (InfulonserCompany != null)
            {
                InfulonserCompany.CompanyId = infulonserCompany.CompanyId;
                InfulonserCompany.InfulonserId = infulonserCompany.InfulonserId;
                InfulonserCompany.Followed = infulonserCompany.Followed;
                _db.SaveChanges();
            }
        }
    }
}
