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
        public double[] Save(PostInfulonser postInfulonser)
        {
            if (postInfulonser.Id == 0)
            {
                _db.PostInfulonsers.Add(postInfulonser);
                _db.SaveChanges();
                double[] data = new double[2];
                data[0] = GetLikesCount(postInfulonser.PostId, "infulonser");
                data[1] = GetDisLikesCount(postInfulonser.PostId, "infulonser");
                return data;
            }
            return null;
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
    }
}
