using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IInfulonserUser
    {
        InfulonserUser GetInfulonserUser(int id);
        IQueryable<InfulonserUser> GetInfulonserUsers { get; }
        void Save(InfulonserUser infulonserUser);
        void Delete(int id);
    }
}
