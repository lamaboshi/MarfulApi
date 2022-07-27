using MarfulApi.Model;
using MarfulApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
namespace MarfulApi.Data
{
    public class SearchRepo : ISearch
    {
        public readonly MarfulDbContext _db;
        public SearchRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public List<object> Search(string search)
        {
            List<object> data = new List<object>();
           List< Infulonser>  inf = _db.Infulonsers.Where(p => p.Name == search).ToList();
            List<Company> cmp = _db.Companies.Where(p => p.Name == search).ToList();
            List<Brand> brand = _db.Brands.Where(p => p.Name == search).Include(r=>r.Infulonser).Include(r=>r.CompanyContent).ToList();
            List<Product> product = _db.Products.Where(p => p.Name == search).Include(r=>r.Brand).ToList();
            List<Content> content = _db.Contents.Where(p => p.Name == search).Include(r=>r.CompanyContent).Include(r=>r.InfulonserContent).ToList();
            if (inf.Count != 0)
            {
                data.AddRange(inf);
            }
            if(cmp.Count != 0)
            {
                data.AddRange(cmp);
            }
            if (brand.Count != 0)
            {
                data.AddRange(brand);
            }
            if (product.Count != 0)
            {
               
                data.AddRange(product);
            }
            if(content.Count != 0)
            {
                //foreach (Content e in content)
                //{
                //    var infContent = _db.InfulonserContents.Where(p => p.ContentId == e.Id).Include(r => r.Infulonser).ToList();
                //    if (infContent != null) data.AddRange(infContent);
                //    var cmpContent = _db.CompanyContents.Where(p => p.ContentId == e.Id).Include(r => r.Company).ToList();
                //    if (cmpContent != null) data.AddRange(content);
                //}
                data.AddRange(content);
            }
            if (data.Count != 0) return data;
            else return null;
        }
        public List<Infulonser> SearchInfulonser(string search)
        {
            List<Infulonser> inf = _db.Infulonsers.Where(p => p.Name == search).ToList();
            return inf;
        }
        public List<Company> SearchCompany(string search)
        {
            List<Company> cmp = _db.Companies.Where(p => p.Name == search).ToList();
            return cmp;

        }
        public List<Brand> SearchBrand(string search)
        {
            List<Brand> brand = _db.Brands.Where(p => p.Name == search).Include(r => r.Infulonser).Include(r => r.CompanyContent).ToList();
            return brand;
        }
        public List<Product> SearchProduct(string search)
        {
            List<Product> product = _db.Products.Where(p => p.Name == search).Include(r => r.Brand).ToList();
            return product;
        }
        public List<Content> SearchContent(string search)
        {
            List<Content> content = _db.Contents.Where(p => p.Name == search).Include(r => r.CompanyContent).Include(r => r.InfulonserContent).ToList();     
           return content;
        }
        public List<object> SearchSelectedContent(int Id, string search)
        {
             List<object> Accounts = new List<object>();
            Content content = _db.Contents.FirstOrDefault(p => p.Id == Id);
            if (content != null)
            {

                var infContent = _db.InfulonserContents.Where(p => p.ContentId == content.Id).Include(r => r.Infulonser).ToList();
                if (infContent != null) Accounts.AddRange(infContent);
                var cmpContent = _db.CompanyContents.Where(p => p.ContentId == content.Id).Include(r => r.Company).ToList();
                if (cmpContent != null) Accounts.AddRange(cmpContent);
                if (Accounts.Count != 0) return Accounts;
                else return null;
            }
                
            else return null;
        }
    }
}
