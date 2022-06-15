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

        public IQueryable<InfulonserContent> GetInfulonserContents => _db.InfulonserContents;

        public void Delete(int id)
        {
            var infulonserContent = _db.InfulonserContents.First(p=> p.Id== id);
            if (infulonserContent != null)
            {
                _db.InfulonserContents.Remove(infulonserContent);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();
            
        }

        public InfulonserContent GetInfulonserContent(int id)
        {
            var infulonserContent = _db.InfulonserContents.First(p => p.Id == id);
            if (infulonserContent != null)
                return infulonserContent;
             else throw new FileNotFoundException();


        }

        public void Save(InfulonserContent infulonserContent)
        {
            if (infulonserContent.Id == 0)
            {
                _db.InfulonserContents.Add(infulonserContent);
                _db.SaveChanges();
            }
        }
        public void Update(InfulonserContent infulonserContent)
        {
            var infulonsercontent = _db.InfulonserContents.First(p => p.Id == infulonserContent.Id);
            if (infulonserContent !=null)
            {
                infulonsercontent.ContentId = infulonserContent.ContentId;
                infulonsercontent.InfulonserId = infulonserContent.InfulonserId;
                _db.SaveChanges();
            }
        }
    }
}
