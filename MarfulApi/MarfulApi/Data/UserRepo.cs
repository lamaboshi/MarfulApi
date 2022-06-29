using MarfulApi.Infrastructure;
using MarfulApi.Model;

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
        public void ChangePassword(User user)
        {
            var data = _db.Users.First(p => p.Id == user.Id);
            if (data != null)
            {
                data.Password = user.Password;
                _db.SaveChanges();
            }
        }
        public List<Post> GetPost(string email)
        {
            User u = _db.Users.First(p => p.Email == email);
            List<Post> posts = new List<Post>();
            List<InfulonserUser> infulonsers = _db.InfulonserUsers.Where(p => p.UserId == u.Id).ToList();
            List<UserCompany> companies = _db.UserCompanies.Where(p => p.UserId == u.Id).ToList();
            
            if(companies != null)
            {
                foreach(UserCompany e in companies)
                {
                    List<CompanyContent> companyContents = _db.CompanyContents.Where(p => p.CompanyId == e.CompanyId).ToList();
                    foreach (CompanyContent n in companyContents)
                    {
                        List<Brand> brands = _db.Brands.Where(p => p.CompanyContentId == e.Id).ToList();

                        foreach (Brand b in brands)
                        {
                           List< Post> compposts = _db.Posts.Where(p => p.BrandId == b.Id).ToList();
                            posts.AddRange(compposts);
                        }
                    }
                }   
            }
            
            if (infulonsers !=null  )
            {
                foreach(InfulonserUser e in infulonsers)
                {
                  List< Post> infposts = _db.Posts.Where(p => p.InfulonserId == e.InfulonserId ).ToList();
                    posts.AddRange(infposts);
                }
            }
            return posts;
            
        }
    }
}
