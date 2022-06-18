using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class InfulonserRepo : IInfulonser
    {
        private readonly MarfulDbContext _db;
        public InfulonserRepo(MarfulDbContext db)
        {
            _db = db;
        }

        public IQueryable<Infulonser> GetInfulonsers => _db.Infulonsers;

        public void Delete(int id)
        {
            var infulonser = _db.Infulonsers.First(p=>p.Id==id);
            if (infulonser != null)
            {
                _db.Infulonsers.Remove(infulonser);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();
        }
        public Infulonser GetInfulonser(int id)
        {
            var infulonser = _db.Infulonsers.First(p=> p.Id==id);
            if (infulonser != null)
                return infulonser;
            else
                throw new FileNotFoundException();
        }
        public void Save(Infulonser infulonser)
        {
            if (infulonser.Id == 0)
            {
                _db.Infulonsers.Add(infulonser);
                _db.SaveChanges();
            }
           
        }
        public void Update(Infulonser infulonser)
        {
            var Infulonser = _db.Infulonsers.First(p => p.Id == infulonser.Id);
            if(Infulonser != null)
            {
                Infulonser.Address = infulonser.Address;
                Infulonser.Description = infulonser.Description;
                Infulonser.Email = infulonser.Email;
                Infulonser.Image = infulonser.Image;
                Infulonser.Name = infulonser.Name;
                Infulonser.Password = infulonser.Password;
                Infulonser.Paypal = infulonser.Paypal;
                Infulonser.Phone = infulonser.Phone;
                Infulonser.UserName = infulonser.UserName;
                _db.SaveChanges();
            }
        }
        public bool IsExisting(string email)
        {
            bool data = _db.Infulonsers.Any(p => p.Email == email);
            if (data == false)
            {
                return false;
            }
            return true;
        }
    }
}
