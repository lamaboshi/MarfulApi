using MarfulApi.Model;
using MarfulApi.Infrastructure;
namespace MarfulApi.Data
{
    public class InfulonserFollowInfulonserRepo : IInfulonserFollowInfulonser
    {
        public readonly MarfulDbContext _db;
        public InfulonserFollowInfulonserRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<InfulonserFollowInfulonser> GetInfulonserFollowInfulonsers => _db.InfulonserFollowInfulonsers;
        public void Delete(int id)
        {
            var infulonserf = _db.InfulonserFollowInfulonsers.First(p => p.Id == id);
            if (infulonserf != null)
            {
                _db.InfulonserFollowInfulonsers.Remove(infulonserf);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();

        }
        public InfulonserFollowInfulonser GetInfulonserFollowInfulonser(int idFollow)
        {
            var infulonserf = _db.InfulonserFollowInfulonsers.First(p => p.FollowId == idFollow);
            if (infulonserf != null)
                return infulonserf;
            else
                throw new NotImplementedException();
        }
        public void Save(InfulonserFollowInfulonser infulonserFollowInfulonser)
        {
            if (infulonserFollowInfulonser.Id == 0)
            {
                _db.InfulonserFollowInfulonsers.Add(infulonserFollowInfulonser);
                _db.SaveChanges();
            }
        }
        public void Update(InfulonserFollowInfulonser infulonserFollowInfulonser)
        {
            var infulonserf = _db.InfulonserFollowInfulonsers.First(p => p.Id == infulonserFollowInfulonser.Id);
            if (infulonserf != null)
            {
                infulonserf.FollowId = infulonserFollowInfulonser.FollowId;
                infulonserf.FollowedId = infulonserFollowInfulonser.FollowedId;
                _db.SaveChanges();
            }
        }
    }
    }

