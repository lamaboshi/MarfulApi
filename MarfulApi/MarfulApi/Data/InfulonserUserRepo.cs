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
        public InfulonserUserRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<InfulonserUser> GetInfulonserUsers => _db.InfulonserUsers;

        public void Delete(int id)
        {
            var infulonserUser = _db.InfulonserUsers.First(p => p.Id == id);
            if (infulonserUser != null)
            {
                _db.InfulonserUsers.Remove(infulonserUser);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();
           
        }
        public InfulonserUser GetInfulonserUser(int id)
        {
            var infulonserUser = _db.InfulonserUsers.First(p => p.Id == id);
            if (infulonserUser != null)

                return infulonserUser;
            else
                 throw new FileNotFoundException();
            

        }
        public void Save(InfulonserUser infulonserUser)
        {
           if(infulonserUser.Id ==0)
                _db.InfulonserUsers.Add(infulonserUser);
                _db.SaveChanges();
           
        }

        public void Update(InfulonserUser infulonserUser)
        {
            var Infulonseruser = _db.InfulonserUsers.First(p => p.Id == infulonserUser.Id);
            if(Infulonseruser !=null)
            {
                Infulonseruser.InfulonserId = infulonserUser.InfulonserId;
                Infulonseruser.UserId = infulonserUser.UserId;
                _db.SaveChanges();
            }
        }
        
    }
}
