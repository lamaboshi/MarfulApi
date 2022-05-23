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
        public IQueryable<Basket> GetStudents => _db.Baskets;
        public void Delete(int id)
        {
            Basket basket = _db.Baskets.Find(id);
            _db.Baskets.Remove(basket);
            _db.SaveChanges();
        }
        public Basket GetBasket(int id)
        {
            Basket basket = _db.Baskets.Find(id);
            return basket;
        }
        public void Save(Basket basket)
        {
            if(basket.Id == 0)
            {
                _db.Baskets.Add(basket);
                _db.SaveChanges();
            }
            else
            {
                Basket Basket = _db.Baskets.Find(basket.Id);
                Basket.TotalPrice = basket.TotalPrice;
                _db.SaveChanges();
            }
        }
    }
}
