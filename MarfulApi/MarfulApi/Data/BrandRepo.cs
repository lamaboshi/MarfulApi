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
        public IQueryable<Brand> GetBrands => throw new NotImplementedException();

        public void Delte(int IdBrand)
        {
            throw new NotImplementedException();
        }

        public Brand GetBrand(int IdBrand)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
