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
  

        public void Delete(int id)
        {
            var result = _db.Products.FirstOrDefault(p => p.Id == id);
            if (result != null)
            {
                _db.Products.Remove(result);
                _db.SaveChanges();
            }
            else throw new FileNotFoundException();
        }

        public Product GetProduct(int id)
        {
            var result = _db.Products.First(p => p.Id == id);
            if (result != null) return result;
            else  throw new NotImplementedException();
        }
        public void Update(Product product)
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
                _db.SaveChanges();
            }

        }
        public void Save(Product product)
        {
            if(product.Id == 0)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
            }
           
        }

        public List<Product> GetProducts(int idBrand)
        {
            var data = _db.Products.Where(t => t.BrandId == idBrand).ToList();
            return data;
        }
    }
}
