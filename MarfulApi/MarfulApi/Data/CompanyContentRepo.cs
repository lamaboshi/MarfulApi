using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class CompanyContentRepo : ICompanyContent
    {
        private readonly MarfulDbContext _db;
        public CompanyContentRepo(MarfulDbContext db)
        {
            _db = db;
        }

        public IQueryable<CompanyContent> GetCompanyContents => _db.CompanyContents;

        public void Delete(int id)
        {
            var companyContent = _db.CompanyContents.Find(id);
            _db.CompanyContents.Remove(companyContent);
            _db.SaveChanges();
        }
        public CompanyContent GetCompanyContent(int id)
        {
            var companyContent = _db.CompanyContents.Find(id);
            return companyContent;
        }
        public void Save(CompanyContent companyContent)
        {
            
                _db.CompanyContents.Add(companyContent);
                _db.SaveChanges();
            
           
        }
    }
}
