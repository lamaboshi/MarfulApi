using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IBasket
    {
       public Basket GetBasket(int id);
       public IQueryable<Basket> GetBaskets { get; }
       public void Save(Basket basket);
      public  void Delete(int id);
        public void Update(Basket basket);
    }
}
