using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.EntityFrameworkCore;
using MarfulApi.Dto;


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
        public double GetMoney(int IdInf,int IdCmp)
        {
           // List<Job> job = new List<Job>();
            List<Post> post = new List<Post>();
            List<UserPost> userPost = new List<UserPost>();
            List<Basket> basket = new List<Basket>();

            //var userPost = _db.UserPosts.Where(p => p.UserId == iduser ).Include(r=>r.Post).ToList();
            //foreach (UserPost e in userPost)
            //{
            //    var post = _db.Posts.Where(p => p.Id == e.PostId && p.JobId != null).Include(r => r.Job).ToList<object>();

            //    foreach (Post n in post)
            //    {
            //        var job = _db.Jobs.Where(p => p.InfulonserId == idinf && p.BrandId == n.BrandId);
            //    }
            //}
            double num = 0;
            var brand = _db.Brands.Where(p => p.CompanyContent.CompanyId == IdCmp).ToList();
            foreach (Brand e in brand)
            {
               Job jobs = _db.Jobs.FirstOrDefault(p => p.BrandId == e.Id && p.InfulonserId == IdInf);
                post = _db.Posts.Where(p => p.JobId == jobs.Id).Include(r => r.UserPost).ThenInclude(r => r.Basket).ToList();
                foreach (Post f in post)
                {
                    var posts = _db.UserPosts.Where(p => p.PostId == f.Id).ToList();
                    userPost.AddRange(posts);
                    
                }

                foreach (UserPost b in userPost)
                {
                    var baskets= _db.Baskets.Where(p => p.UserPostId == b.Id).Include(r => r.Product).ToList();
                    basket.AddRange(baskets); 
                }
                foreach(Basket h in basket)
                {
                    num += h.TotalPrice;
                }
                double c = jobs.Salary / 100;
                num = num  * c;
            }
            if (num != 0) return num;
            return 0;
        }
        public List<InformationDto> GetReport(int IdInf)
        {
            var infulonser = _db.Infulonsers.FirstOrDefault(p => p.Id == IdInf);
            if(infulonser != null)
            {
                List<InformationDto> informationDtos = new List<InformationDto>();
                InformationDto dto = new InformationDto();
                List<User> u = new List<User>();
                List<UserPost> userpost = new List<UserPost>();
               var job = _db.Jobs.Where(p => p.InfulonserId == infulonser.Id).Include(r=>r.Brand).ThenInclude(r=>r.Post).ToList();
                foreach (Job e in job)
                {
                    dto.jobId = e.Id;
                    var data = _db.CompanyContents.FirstOrDefault(p => p.Id == e.Brand.CompanyContentId);
                    //foreach (CompanyContent f in data)
                    //{
                        var company = _db.Companies.FirstOrDefault(p => p.Id == data.CompanyId);
                        double h = GetMoney(infulonser.Id, company.Id);
                        dto.company = company;
                        dto.salary = h;
                   // }
                    var posts = _db.Posts.Where(p=>p.JobId==e.Id ).Include(r=>r.UserPost).ThenInclude(r=>r.User).ToList();
                    foreach (Post g in posts)
                    {
                        userpost = _db.UserPosts.Where(p => p.PostId == g.Id).Include(r => r.User).ToList();

                        foreach (UserPost m in userpost)
                        {
                            User user = _db.Users.FirstOrDefault(p => p.Id == m.UserId);
                            if(u.Contains(user) !=true)
                            u.Add(user);
                        }
                    }
                    dto.user = u;
                    informationDtos.Add(dto);
                }
                if (informationDtos.Count != 0) return informationDtos;
                else return null;
            }
            return null;
        }
    }
}
