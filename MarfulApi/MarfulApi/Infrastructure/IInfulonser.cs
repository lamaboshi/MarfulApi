using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IInfulonser
    {
       public Infulonser GetInfulonser(int id);
       public IQueryable<Infulonser> GetInfulonsers { get; }
       public void Save(Infulonser infulonser);
       public void Delete(int id);
       public void Update(Infulonser infulonser);
        public bool IsExisting(string email);
        public void ChangePassword(Infulonser infulonser);
        
    }
}
