using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IProduct
    {
        Product GetProduct(int id);
        IQueryable<Product> GetProducts { get; }
        void Save(Product product);
        void Delete(int id);
    }
}
