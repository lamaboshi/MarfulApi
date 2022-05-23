using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;

using MarfulApi.Model;
namespace MarfulApi.Data
{
    public class InfulonserContentRepo : IInfulonserContent
    {
        private readonly MarfulDbContext _db;
        public InfulonserContentRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<InfulonserContent> GetInfulonserContent => _db.InfulonserContents;
        public void Delete(int id)
        {
            InfulonserContent infulonserContent = _db.InfulonserContents.Find(id);
            _db.InfulonserContents.Remove(infulonserContent);
            _db.SaveChanges();
        }
        public InfulonserContent GetInfulonserContent(int id)
        {
            InfulonserContent infulonserContent = _db.InfulonserContents.Find(id);
            return infulonserContent;
        }
        public void Save(InfulonserContent infulonserContent)
        {
           
                _db.InfulonserContents.Add(infulonserContent);
                _db.SaveChanges();
            
        }
    }
}
