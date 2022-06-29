using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IInfulonserUser
    {
        public  InfulonserUser GetInfulonserUser(int id);
        public List<InfulonserUser> GetAllInfulonserUsers(int IdUser);
        public void Save(InfulonserUser infulonserUser);
        public void Delete(int id);
        public void Update(InfulonserUser infulonserUser);
    }
}
