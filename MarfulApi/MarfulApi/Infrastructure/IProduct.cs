using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IProduct
    {
        public Product GetProduct(int id);
       public  IQueryable<Product> GetProducts { get; }
       public void Save(Product product);
      public  void Delete(int id);
    }
}
