using MarfulApi.Infrastructure;
using MarfulApi.Model;
using MarfulApi.Dto;
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
        public List<Brand> GetCompanyBrand(int id)
        {
            var result = _db.Brands.Where(p => p.CompanyContentId == id).ToList();
            if (result != null) return result;
            else throw new NotImplementedException();
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

            var posts = _db.Companies.Where(p => p.Id == Id).SelectMany(p => p.CompanyContent.SelectMany(t => t.Brand.SelectMany(y => y.Post))).Include(r => r.UserPost).Include(r => r.Brand).ToList();
            return posts;

        }

        public double GetFollowersCount(string email)
        {
            Company company = _db.Companies.FirstOrDefault(p => p.Email == email);
            if (company != null)
            {
                double inf = _db.CompanyInfulonsers.Where(p => p.CompanyId == company.Id && p.Followed=="company").Count();
                double user = _db.UserCompanies.Where(p => p.CompanyId == company.Id).Count();
                return inf + user;
            }
            else return -1;
        }
        public List<object> GetFollowers(string email)
        {
            Company company = _db.Companies.FirstOrDefault(p => p.Email == email);
            if (company != null)
            {
                List<object> followers = new List<object>();
                List<CompanyInfulonser> com = _db.CompanyInfulonsers.Where(p => p.CompanyId == company.Id && p.Followed == "company").ToList();
                foreach (CompanyInfulonser e in com)
                {
                    Infulonser infAcount = _db.Infulonsers.Where(p => p.Id == e.InfulonserId).FirstOrDefault();
                    followers.Add(infAcount);
                }
                List<UserCompany> user = _db.UserCompanies.Where(p => p.CompanyId == company.Id).ToList();
                foreach (UserCompany e in user)
                {
                    User userAcount = _db.Users.Where(p => p.Id == e.UserId).FirstOrDefault();
                    followers.Add(userAcount);
                }
                return followers;
            }
            else return null;
        }
        public CompanyWebDto GetCompanyAll(string email)
        {
            CompanyWebDto data = new CompanyWebDto();
            Company company = _db.Companies.FirstOrDefault(p => p.Email == email);
            if(company != null)
            {
                var comp = _db.Companies.Where(p => p.Id == company.Id).SelectMany(p => p.CompanyContent.SelectMany(t => t.Brand.SelectMany(y => y.Product))).Include(r => r.Brand).ThenInclude(r=>r.Product).ToList();
               if(comp.Count != 0)
                { 
                data.company = company;
                data.products = comp;
                return data;
                 }
            }
            return null;
        }
    }
}
