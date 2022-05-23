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
  
        public void Delete(int id)
        {
            Content content = _db.Contents.Find(id);
            _db.Contents.Remove(content);
            _db.SaveChanges();
        }
        public Content GetContent(int id)
        {
            Content content = _db.Contents.Find(id);
            return content;
        }
        public void Save(Content content)
        {
            if (content.Id == 0)
            {
                _db.Contents.Add(content);
                _db.SaveChanges();
            }
            else
            {
                Content Content = _db.Contents.Find(content.Id);
                Content.Name = content.Name;
                Content.Description = content.Description;
                _db.SaveChanges();
            }
        }
    }
}
