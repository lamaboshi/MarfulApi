using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.EntityFrameworkCore;

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

        public void Delete(int id,int IdComp)
        {
            var companyContent = _db.CompanyContents.First(p=> p.ContentId == id&&p.CompanyId==IdComp);
            if (companyContent != null)
            {
                _db.CompanyContents.Remove(companyContent);
                _db.SaveChanges();
            }
         
           
        }
        public List<CompanyContent> GetAllCompanyContents(int IdCompany)
        {
            var data = _db.CompanyContents.Where(p => p.CompanyId == IdCompany).Include(t => t.Content).ToList();
            return data;
        }
        public CompanyContent GetCompanyContent(int id)
        {
            var companyContent = _db.CompanyContents.First(p=> p.Id ==id);
            if (companyContent != null)
                return companyContent;
            else
                return null;
        }
        public void Save(CompanyContent companyContent)
        {
            if (companyContent.Id == 0)
            {
                _db.CompanyContents.Add(companyContent);
                _db.SaveChanges();
            }
        }
        public void Update(CompanyContent companyContent)
        {
            var companycontent = _db.CompanyContents.First(p => p.Id == companyContent.Id);
            if(companyContent != null)
            {
                companycontent.CompanyId = companyContent.CompanyId;
                companycontent.ContentId = companyContent.ContentId;
                _db.SaveChanges();
            }
        }
    }
}
