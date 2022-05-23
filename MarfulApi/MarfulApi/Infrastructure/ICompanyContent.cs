using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface ICompanyContent
    {
      public  CompanyContent GetCompanyContent(int id);
       public IQueryable<CompanyContent> GetCompanyContents { get; }
      public  void Save(CompanyContent companyContent);
      public  void Delete(int id);
    }
}
