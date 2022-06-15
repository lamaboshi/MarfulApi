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
            var result = _db.UserPosts.First(p => p.Id == id);
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

        public void Save(UserPost user)
        {
            if (user.Id == 0)
            {
                _db.UserPosts.Add(user);
                _db.SaveChanges();
            }
        }
    }
}
