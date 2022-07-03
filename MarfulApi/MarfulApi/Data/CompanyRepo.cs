using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MarfulApi.Data
{
    public class CompanyRepo : ICompany
    {
        private readonly MarfulDbContext _db;
        public CompanyRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Company> GetCompanys => _db.Companies;

        public void Delete(int id)
        {
            var result = _db.Companies.First(p => p.Id == id);
            if (result != null)
            {
                _db.Companies.Remove(result);
                _db.SaveChanges();
            }
        }

        public Company GetCompany(int id)
        {
            var result = _db.Companies.First(p => p.Id == id);
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public void Save(Company company)
        {

            if (company.Id == 0)
            {
                _db.Companies.Add(company);
                _db.SaveChanges();
            }
        }

        public void Update(Company company)
        {
            if (company.Id != 0)
            {
                var companyEntity = _db.Companies.First(t => t.Id == company.Id);
                if (companyEntity != null)
                {
                    companyEntity.Name = company.Name;
                    companyEntity.Phone = company.Phone;
                    companyEntity.Email = company.Email;
                    companyEntity.TelePhone = company.TelePhone;
                    companyEntity.Address = company.Address;
                    companyEntity.Image = company.Image;
                    companyEntity.Description = company.Description;
                    _db.SaveChanges();
                }
            }
        }
        public bool IsExisting(string email)
        {
            bool data = _db.Companies.Any(p => p.Email == email);
            if (data == false)
            {
                return false;
            }
            return true;
        }
        public void ChangePassword(int Id,string password)
        {
            var data = _db.Companies.First(p => p.Id == Id);
            if (data != null)
            {
                data.Password = password;
                _db.SaveChanges();
            }
            
        }

        public  List<Post> GetAllCompanyPost(int Id)
        {
            var posts =  _db.Companies.Where(p=>p.Id==Id).SelectMany(p=>p.CompanyContent.SelectMany(t=>t.Brand.SelectMany(y=>y.Post))).Include(r=>r.Brand).ToList();
            return posts;

        }
    }
}
