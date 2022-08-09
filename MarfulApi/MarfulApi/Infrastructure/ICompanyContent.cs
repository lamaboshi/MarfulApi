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
      public  void Delete(int id, int IdComp);
        public void Update(CompanyContent companycontent);
        public List<CompanyContent> GetAllCompanyContents(int IdCompany);
    }
}
