using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class BrandRepo : IBrand
    {
        private readonly MarfulDbContext _db;
        public BrandRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Brand> GetBrands => _db.Brands;

        public void Delete(int IdBrand)
        {
            var brand = _db.Brands.First(t => t.Id == IdBrand);
            if (brand != null)
            {
                var product = _db.Products.Where(p => p.BrandId == brand.Id).ToList();
                if (product.Count != 0) _db.Products.RemoveRange(product);
                var job = _db.Jobs.Where(p => p.BrandId == brand.Id).ToList();
                if(job.Count != 0)
                {
                    JobRepo repo = new JobRepo(_db);
                    foreach(Job e in job)
                    {
                        repo.Delete(e.Id);
                    }
                }
                var post = _db.Posts.Where(p => p.BrandId == brand.Id).ToList();
                if (post.Count != 0) _db.Posts.RemoveRange(post);
                _db.Brands.Remove(brand);
                _db.SaveChanges();
            }
            
        }

        public Brand GetBrand(int IdBrand)
        {
            var brand = _db.Brands.FirstOrDefault(t => t.Id == IdBrand);
            if (brand != null) return brand;
            else return null;

        }

        public void Save(Brand brand)
        {
            if (brand.Id == 0)
            {
                _db.Brands.Add(brand);
                _db.SaveChanges();
            }
        }

        public void Update(Brand brand)
        {
            var brandEntity = _db.Brands.First(t => t.Id == brand.Id);
            if (brandEntity != null)
            {
                brandEntity.Name = brand.Name;
                brandEntity.Description = brand.Description;
                brandEntity.Image = brand.Image;
                brandEntity.InfulonserId = brand.InfulonserId;
                brandEntity.CompanyContentId = brand.CompanyContentId;
                _db.SaveChanges();
            }
        }
    }
}
