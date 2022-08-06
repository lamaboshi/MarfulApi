using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class PostRepo : IPost
    {
        private readonly MarfulDbContext _db;
        public PostRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Post> GetPosts => _db.Posts;

        public void Delete(int id)
        {
            var result = _db.Posts.First(p => p.Id == id);
            if (result != null)
            {
                _db.Posts.Remove(result);
                _db.SaveChanges();
            }
        }

        public Post GetPost(int IdPost)
        {
            var result = _db.Posts.First(p => p.Id == IdPost);
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public void Save(Post post)
        {
            if (post.Id == 0)
            {

                _db.Posts.Add(post);
                _db.SaveChanges();
            }
        }

        public void Update(Post post)
        {
            if (post.Id != 0)
            {
                var postEntity = _db.Posts.First(t => t.Id == post.Id);
                if (postEntity != null)
                {
                    postEntity.Description = post.Description;
                    postEntity.Image = post.Image;
                    postEntity.BrandId = post.BrandId;
                    postEntity.JobId = post.JobId;
                    postEntity.InfulonserId = post.InfulonserId;
                    _db.SaveChanges();
                }
            }
        }
    }
}
