using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MarfulApi.Data
{
    public class ProductRepo : IProduct
    {
        private readonly MarfulDbContext _db;
        public ProductRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Product> GetProducts => _db.Products;

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
            if(product.Id != 0)
            {
                var prodectEntity = _db.Products.First(t => t.Id == product.Id);
                if (prodectEntity != null)
                {
                    prodectEntity.Name = product.Name;
                    prodectEntity.Price = product.Price;
                    prodectEntity.Image = product.Image;
                    prodectEntity.Code = product.Code;
                    prodectEntity.BrandId = product.BrandId;
                    prodectEntity.Description = product.Description;

                }

            }
            else
            {
                _db.Products.Add(product);
            }
            _db.SaveChanges();
        }
    }
}
