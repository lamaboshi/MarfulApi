using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;
using MarfulApi.Model;


namespace MarfulApi.Data
{
    public class BasketRepo : IBasket
    {
        private readonly MarfulDbContext _db;
        public BasketRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Basket> GetBaskets => _db.Baskets;
        public void Delete(int id)
        {
            var basket = _db.Baskets.First(p => p.Id == id);
            if (basket != null)
            {
                _db.Baskets.Remove(basket);
                _db.SaveChanges();
            }
            else
                throw new FileNotFoundException();

        }
        public Basket GetBasket(int id)
        {
            var basket = _db.Baskets.First(p => p.Id == id);
            if (basket != null)
               return basket;
            else
                 throw new NotImplementedException();
        }
        public void Save(Basket basket)
        {
            if(basket.Id == 0)
            {
                _db.Baskets.Add(basket);
                _db.SaveChanges();
            }
           
        }
        public void Update(Basket basket)
        {
            var Basket = _db.Baskets.First(p => p.Id == basket.Id);
            if(Basket != null)
            {
                Basket.ProductId = basket.ProductId;
                Basket.TotalPrice = basket.TotalPrice;
                Basket.UserPostId = basket.UserPostId;
                _db.SaveChanges();
            }
        }
    }
}
