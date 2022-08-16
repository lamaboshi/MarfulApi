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
           

        }
        public CompanyInfulonser GetInfulonserCompany(int idcompany,int idInfo)
        {
            var infulonserCompany = new CompanyInfulonser();
            if (idcompany==0)
            {
                infulonserCompany = _db.CompanyInfulonsers.First(p => p.InfulonserId == idInfo);
            }else if (idInfo == 0)
            {
                infulonserCompany = _db.CompanyInfulonsers.First(p => p.CompanyId == idcompany);
            }
            
            if (infulonserCompany != null)
                return infulonserCompany;
            else
                return null;
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
