using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class ContentRepo : IContent
    {
        private readonly MarfulDbContext _db;
        public ContentRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Content> GetContents => _db.Contents;
  
        public void Delete(int id)
        {
            var content = _db.Contents.FirstOrDefault(p => p.Id == id);
            if (content != null)
            {
                _db.Contents.Remove(content);
                _db.SaveChanges();
            }
            else throw new FileNotFoundException();
            
        }
        public Content GetContent(int id)
        {
            var content = _db.Contents.First(p => p.Id == id);
            if (content != null)
                return content;
            else
                throw new FileNotFoundException();
           
        }
        public void Save(Content content)
        {
            if (content.Id == 0)
            {
                _db.Contents.Add(content);
                _db.SaveChanges();
            }
           
        }
        public void  Update(Content content)
        {
            var Content = _db.Contents.First(p => p.Id == content.Id);
            if(Content != null)
            {
                Content.Name = content.Name;
                Content.Description = content.Description;
                _db.SaveChanges();
            }
        }
    }
}
