using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IUserPost
    {
        public void Save(UserPost job);
        public IQueryable<UserPost> GetUserPosts { get; }
        public UserPost GetUserPost(int IdUserPost);
        public void Delete(int id);
    }
}
