using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IInfulonserContent
    {
        public List<Content> GetAllInfulonserContents(int IdInful);
        public InfulonserContent GetInfulonserContent(int id);
        public void Save(InfulonserContent infulonserContent);
        public void Delete(int id, int IdInu);
        public void Update(InfulonserContent infulonserContent);
    }
}
