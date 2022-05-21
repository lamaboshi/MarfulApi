using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class ContentRepo: IContent
    {
        private readonly MarfulDbContext _db;
        public ContentRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Content> GetContents => _db.Contents;
    }
}
