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

        public void Delte(int IdBrand)
        {
            var brand = _db.Brands.First(t => t.Id == IdBrand);
            if (brand != null)
            {
                _db.Brands.Remove(brand);
                _db.SaveChanges();
            }
        }

        public Brand GetBrand(int IdBrand)
        {
            var brand = _db.Brands.First(t => t.Id == IdBrand);
            if (brand != null) return brand;
            else throw new NotImplementedException();

        }

        public void Save(Brand brand)
        {
            if (brand.Id!=0)
            {
                _db.Brands.Add(brand);
            }
            else
            {
                var brandEntity = _db.Brands.Find(brand.Id);
                brandEntity.Name = brand.Name;
              
            }
            _db.SaveChanges();
        }
    }
}
