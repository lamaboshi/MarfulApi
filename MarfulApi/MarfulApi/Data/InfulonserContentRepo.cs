using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;

using MarfulApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MarfulApi.Data
{
    public class InfulonserContentRepo : IInfulonserContent
    {
        private readonly MarfulDbContext _db;
        public InfulonserContentRepo(MarfulDbContext db)
        {
            _db = db;
        }


        public void Delete(int id,int IdInu)
        {
            var infulonserContent = _db.InfulonserContents.First(p=> p.ContentId== id&&p.InfulonserId==IdInu);
            if (infulonserContent != null)
            {
                _db.InfulonserContents.Remove(infulonserContent);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();
            
        }

        public List<Content> GetAllInfulonserContents(int IdInful)
        {
               var data = _db.InfulonserContents.Where(p => p.InfulonserId == IdInful).Include(t => t.Content).Select(o=>o.Content).ToList();
            return data;
        }

        public InfulonserContent GetInfulonserContent(int id)
        {
            var infulonserContent = _db.InfulonserContents.Where(p => p.InfulonserId == id).Include(t=>t.Content).First();
            return infulonserContent;


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
