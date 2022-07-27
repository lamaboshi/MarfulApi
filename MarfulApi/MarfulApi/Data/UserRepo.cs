using MarfulApi.Infrastructure;
using MarfulApi.Model;
using MarfulApi.Dto;
namespace MarfulApi.Data
{
    public class UserRepo : IUser
    {
        private readonly MarfulDbContext _db;
        public UserRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<User> GetUsers => _db.Users;

        public void Delete(int id)
        {
            var result = _db.Users.First(p => p.Id == id);
            if (result != null)
            {
                _db.Users.Remove(result);
                _db.SaveChanges();
            }
        }

        public User GetUser(int id)
        {
            var result = _db.Users.First(p => p.Id == id);
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public void Save(User user)
        {

            if (user.Id == 0)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
            }
        }

        public void Update(User user)
        {
            if (user.Id != 0)
            {
                var userEntity = _db.Users.First(t => t.Id == user.Id);
                if (userEntity != null)
                {
                    userEntity.Name = user.Name;
                    userEntity.Image = user.Image;
                    userEntity.Age = user.Age;
                    userEntity.Password = user.Password;
                    userEntity.Paypal = user.Paypal;
                    userEntity.Phone = user.Phone;
                    userEntity.UserName = user.UserName;
                    userEntity.Email = user.Email;
                    _db.SaveChanges();
                }
            }
        }
        public bool IsExisting(string email)
        {
            bool data = _db.Users.Any(p => p.Email == email);
            if (data == false)
            {
                return false;
            }
            return true;
        }
        public void ChangePassword(int Id,string password)
        {
            var data = _db.Users.First(p => p.Id == Id);
            if (data != null)
            {
                data.Password = password;
                _db.SaveChanges();
            }
        }
        public List<object> GetFollowed(string email)
        {
            User user = _db.Users.FirstOrDefault(p => p.Email == email);
            List<object> Account = new List<object>();
            if (user != null)
            {
                List<InfulonserUser> infulonsers = _db.InfulonserUsers.Where(p => p.UserId == user.Id).ToList();
                List<UserCompany> companies = _db.UserCompanies.Where(p => p.UserId == user.Id).ToList();
                if (infulonsers == null && companies == null) return null;
                if (infulonsers.Count !=0)
                {
                    foreach(InfulonserUser e in infulonsers)
                    {
                        Infulonser infAcount = _db.Infulonsers.FirstOrDefault(p => p.Id == e.InfulonserId);
                        Account.Add(infAcount);
                    }
                }
                 if (companies.Count != 0)
                {
                    foreach(UserCompany e in companies)
                    {
                        Company cmpAcount = _db.Companies.FirstOrDefault(p => p.Id == e.CompanyId);
                        Account.Add(cmpAcount);
                    }
                }
                return Account;
            }
            else return null;
        }
        public double GetFollowedCount(string email)
        {
            User user = _db.Users.FirstOrDefault(p => p.Email == email);
            if (user != null)
            {
                double infCount = _db.InfulonserUsers.Where(p => p.UserId == user.Id).Count();
                double cmpCount = _db.UserCompanies.Where(p => p.UserId == user.Id).Count();
                return infCount + cmpCount;
            }
            else return -1;
        }
    }
}
