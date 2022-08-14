using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class UserPostRepo : IUserPost
    {
        private readonly MarfulDbContext _db;
        public UserPostRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<UserPost> GetUserPosts => _db.UserPosts;

        public void Delete(int id)
        {
            var result = _db.UserPosts.FirstOrDefault(p => p.Id == id);
            if (result != null)
            {
                _db.UserPosts.Remove(result);
                _db.SaveChanges();
            }
        }

        public UserPost GetUserPost(int IdUserPost)
        {
            var result = _db.UserPosts.First(p => p.Id == IdUserPost);
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public double[] Save(UserPost user)
        {
            if (user.Id == 0)
            {
                _db.UserPosts.Add(user);
                _db.SaveChanges();
                double[] data = new double[2];
                data[0] = GetLikesCount(user.PostId, "user");
                data[1] = GetDisLikesCount(user.PostId, "user");
                return data;
            }
            return null;
        }
        public double GetLikesCount(int id, string Type)
        {
            if (Type == "company")
            {
                return -1;
            }
            else if (Type == "infulonser" || Type == "user")
            {
                double userCount = _db.UserPosts.Where(p => p.PostId == id && p.InterAction == true).Count();
                double infuCount = _db.PostInfulonsers.Where(p => p.PostId == id && p.Interaction == true).Count();
                return userCount + infuCount;
            }
            return -1;
        }
        public double GetDisLikesCount(int id, string Type)
        {
            if (Type == "company")
            {
                return -1;
            }
            else if (Type == "infulonser" || Type == "user")
            {
                double userCount = _db.UserPosts.Where(p => p.PostId == id && p.InterAction == false).Count();
                double infuCount = _db.PostInfulonsers.Where(p => p.PostId == id && p.Interaction == false).Count();
                return userCount + infuCount;
            }
            return -1;
        }

        public List<UserPost> GetUserPostByUser(int IdUser)
        {
            var data = _db.UserPosts.Where(t => t.UserId == IdUser).ToList();
            return data;
        }
    }
}
