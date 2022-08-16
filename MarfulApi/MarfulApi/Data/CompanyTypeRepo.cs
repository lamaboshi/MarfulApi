using MarfulApi.Model;
using MarfulApi.Infrastructure;
namespace MarfulApi.Data
{
    public class CompanyTypeRepo :ICompanyType
    {
        public readonly MarfulDbContext _db;
        public CompanyTypeRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<CompanyType> GetCompanyTypes => _db.CompanyTypes;
        public void Delete(int id)
        {
            var type = _db.CompanyTypes.FirstOrDefault(p => p.Id == id);
            if (type != null)
            {
                _db.CompanyTypes.Remove(type);
                _db.SaveChanges();
            }
      

        }
        public CompanyType GetCompanyType(int id)
        {
            var type = _db.CompanyTypes.First(p => p.Id == id);
            if (type != null)
                return type;
            else
                return null;
        }
        public void Save(CompanyType companyType)
        {
            if (companyType.Id == 0)
            {
                _db.CompanyTypes.Add(companyType);
                _db.SaveChanges();
            }

        }
        public void Update(CompanyType companyType)
        {
            var type = _db.CompanyTypes.First(p => p.Id == companyType.Id);
            if (type != null)
            {
                type.CompanyId = companyType.CompanyId;
                type.type = companyType.type;
                _db.SaveChanges();
            }
        }
        public CompanyType IsExisting(string Type, string Password)
        {
            var data = _db.CompanyTypes.FirstOrDefault(p => p.type == Type && p.Password == Password);
            if (data != null)
            {
                return data;
            }
            else return null;
        }
        public List<CompanyType> getTypes(int IdCmp)
        {
            var data = _db.CompanyTypes.Where(p => p.CompanyId == IdCmp).ToList();
            if (data != null) return data;
            else return null;
        }
    }
}
