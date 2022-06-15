using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IPost
    {
        public void Update(Post post);
        public void Save(Post post);
        public IQueryable<Post> GetPosts { get; }
        public void Delete(int id);
        public Post GetPost(int IdPost);
    }
}
