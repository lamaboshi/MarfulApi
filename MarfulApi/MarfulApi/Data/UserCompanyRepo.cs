using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class UserCompanyRepo : IUserCompany
    {
        private readonly MarfulDbContext _db;
        public UserCompanyRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<UserCompany> GetUserCompanys => _db.UserCompanies;

        public void Delete(int id)
        {
            var result = _db.UserCompanies.First(p => p.Id == id);
            if (result != null)
            {
                _db.UserCompanies.Remove(result);
                _db.SaveChanges();
            }
        }

        public UserCompany GetUserCompany(int id)
        {
            var result = _db.UserCompanies.First(p => p.Id == id);
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public void Save(UserCompany userCompany)
        {
            if (userCompany.Id == 0)
            {
                _db.UserCompanies.Add(userCompany);
                _db.SaveChanges();
            }
        }

    }
}
