using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class ProductRepo : IProduct
    {
        public IQueryable<Product> GetProducts => throw new NotImplementedException();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
