using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IUserPost
    {
        public double[] Save(UserPost job);
        public IQueryable<UserPost> GetUserPosts { get; }
        public UserPost GetUserPost(int IdUserPost);
        public void Update(UserPost userPost);
        public List<UserPost> GetUserPostByUser(int IdUser);
        public void Delete(int id);
    }
}
