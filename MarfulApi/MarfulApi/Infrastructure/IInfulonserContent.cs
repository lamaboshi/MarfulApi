using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IInfulonserContent
    {
       public InfulonserContent GetInfulonserContent(int id);
        public IQueryable<InfulonserContent> GetInfulonserContents { get; }
        public void Save(InfulonserContent infulonserContent);
        public void Delete(int id);
        public void Update(InfulonserContent infulonserContent);
    }
}
