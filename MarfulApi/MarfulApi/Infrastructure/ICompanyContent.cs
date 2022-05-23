using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface ICompanyContent
    {
        CompanyContent GetCompanyContent(int id);
        IQueryable<CompanyContent> GetCompanyContents { get; }
        void Save(CompanyContent companyContent);
        void Delete(int id);
    }
}
