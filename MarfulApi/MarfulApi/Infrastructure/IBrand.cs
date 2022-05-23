using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IBrand
    {
        public void Save();
        public IQueryable<Brand> GetBrands { get;  }
        public void Delte(int IdBrand);
        public Brand GetBrand(int IdBrand);
    }
}
