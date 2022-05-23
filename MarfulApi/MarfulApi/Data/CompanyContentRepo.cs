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
        public BasketRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Basket> GetCompanyContent => _db.CompanyContents;
        public void Delete(int id)
        {
            CompanyContent companyContent = _db.CompanyContents.Find(id);
            _db.Baskets.Remove(companyContent);
            _db.SaveChanges();
        }
        public CompanyContent GetCompanyContent(int id)
        {
            CompanyContent companyContent = _db.CompanyContents.Find(id);
            return basket;
        }
        public void Save(CompanyContent companyContent)
        {
            
                _db.CompanyContents.Add(companyContent);
                _db.SaveChanges();
            
           
        }
    }
}
