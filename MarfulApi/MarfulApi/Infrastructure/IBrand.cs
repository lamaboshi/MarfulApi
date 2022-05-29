using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IBrand
    {
        public void Update(Brand brand);
        public void Save(Brand brand);
        public IQueryable<Brand> GetBrands { get;  }
        public void Delete(int id);
        public Brand GetBrand(int IdBrand);
    }
}
