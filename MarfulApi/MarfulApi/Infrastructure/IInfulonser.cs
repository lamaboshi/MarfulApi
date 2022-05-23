using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IInfulonser
    {
        Infulonser GetInfulonser(int id);
        IQueryable<Infulonser> GetInfulonsers { get; }
        void Save(Infulonser infulonser);
        void Delete(int id);
    }
}
