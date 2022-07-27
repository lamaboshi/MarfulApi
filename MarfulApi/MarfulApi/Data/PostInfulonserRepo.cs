using MarfulApi.Model;
using MarfulApi.Infrastructure;
namespace MarfulApi.Data
{
    public class PostInfulonserRepo:IPostInfulonser
    {
        public readonly MarfulDbContext _db;
        public PostInfulonserRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<PostInfulonser> GetPostInfulonsers => _db.PostInfulonsers;
        public void Delete(int id)
        {
            var postInfulonser = _db.PostInfulonsers.First(p => p.Id == id);
            if (postInfulonser != null)
            {
                _db.PostInfulonsers.Remove(postInfulonser);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();

        }
        public PostInfulonser GetPostInfulonser(int id)
        {
            var postInfuloser = _db.PostInfulonsers.First(p => p.Id == id);
            if (postInfuloser != null)
                return postInfuloser;
            else
                throw new NotImplementedException();
        }
        public void Save(PostInfulonser postInfulonser)
        {
            if (postInfulonser.Id == 0)
            {
                _db.PostInfulonsers.Add(postInfulonser);
                _db.SaveChanges();
            }

        }
        public void Update(PostInfulonser postInfulonser)
        {
            var PostInfulonser = _db.PostInfulonsers.First(p => p.Id == postInfulonser.Id);
            if (PostInfulonser != null)
            {
                PostInfulonser.InfulonserId = postInfulonser.InfulonserId;
                PostInfulonser.Interaction = postInfulonser.Interaction;
                PostInfulonser.PostId = postInfulonser.PostId;
                _db.SaveChanges();
            }
        }
    }
}
