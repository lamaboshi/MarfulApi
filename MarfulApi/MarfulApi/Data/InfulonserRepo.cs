using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class InfulonserRepo :  IInfulonser
    {
        private readonly MarfulDbContext _db;
        public InfulonserRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Infulonser> GetStudents => _db.Infulonsers;
        public void Delete(int id)
        {
            Infulonser infulonser = _db.Infulonsers.Find(id);
            _db.Infulonsers.Remove(infulonser);
            _db.SaveChanges();
        }
        public Infulonser GetInfulonser(int id)
        {
            Infulonser infulonser = _db.Infulonsers.Find(id);
            return infulonser;
        }
        public void Save(Infulonser infulonser)
        {
            if (infulonser.Id == 0)
            {
                _db.Infulonsers.Add(infulonser);
                _db.SaveChanges();
            }
            else
            {
                Infulonser Infulonser = _db.Infulonsers.Find(infulonser.Id);
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
    }
}
