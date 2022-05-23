using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class InfulonserUserRepo : IInfulonserUser
    {
        private readonly MarfulDbContext _db;
        public BasketRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<InfulonserUser> GetInfulonserUser => _db.InfulonserUsers;
        public void Delete(int id)
        {
            InfulonserUser infulonserUser = _db.InfulonserUsers.Find(id);
            _db.InfulonserUsers.Remove(infulonserUser);
            _db.SaveChanges();
        }
        public InfulonserUser GetInfulonserUser (int id)
        {
            InfulonserUser infulonserUser = _db.InfulonserUsers.Find(id);
            return infulonserUser;
        }
        public void Save(InfulonserUser infulonserUser)
        {
           
                _db.InfulonserUsers.Add(infulonserUser);
                _db.SaveChanges();
           
        }
    }
}
