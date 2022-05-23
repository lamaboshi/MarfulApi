using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IInfulonserContent
    {
        InfulonserContent GetInfulonserContent(int id);
        IQueryable<InfulonserContent> GetInfulonserContents { get; }
        void Save(InfulonserContent basket);
        void Delete(int id);
    }
}
