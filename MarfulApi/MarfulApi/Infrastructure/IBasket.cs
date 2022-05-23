using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IBasket
    {
        Basket GetBasket(int id);
        IQueryable<Basket> GetStudents { get; }
        void Save(Basket basket);
        void Delete(int id);
    }
}
