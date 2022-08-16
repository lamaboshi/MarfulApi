using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Infrastructure;
using MarfulApi.Model;
using MarfulApi.Dto;
using Microsoft.EntityFrameworkCore;

namespace MarfulApi.Data
{
    public class InfulonserRepo : IInfulonser
    {
        private readonly MarfulDbContext _db;
        public InfulonserRepo(MarfulDbContext db)
        {
            _db = db;
        }

        public IQueryable<Infulonser> GetInfulonsers => _db.Infulonsers;

        public List<Post> getAllPostInfulonser(int Id) {
            var data = _db.Posts.Where(p => p.InfulonserId == Id).ToList();
            return data;
        }

        public void Delete(int id)
        {
            var infulonser = _db.Infulonsers.First(p=>p.Id==id);
            if (infulonser != null)
            {
                var data = _db.InfulonserFollowInfulonsers.Where(p => p.FollowedId == infulonser.Id).ToList();
                if (data.Count != 0) _db.InfulonserFollowInfulonsers.RemoveRange(data);
                var infUser = _db.InfulonserUsers.Where(p => p.InfulonserId == infulonser.Id).ToList();
                if (infUser.Count != 0) _db.InfulonserUsers.RemoveRange(infUser);
                var cmpInf = _db.CompanyInfulonsers.Where(p => p.InfulonserId == infulonser.Id).ToList();
                if (cmpInf.Count != 0) _db.CompanyInfulonsers.RemoveRange(cmpInf);
                var Job = _db.Jobs.Where(p => p.InfulonserId == infulonser.Id).ToList();
                if (Job.Count != 0)
                {
                    JobRepo repo = new JobRepo(_db);
                   foreach(Job e in Job)
                    {
                        repo.Delete(e.Id);
                    }
                }
                var Conversation = _db.Conversations.Where(p => p.InfulonserId == infulonser.Id).ToList();
                if (Conversation.Count != 0) _db.Conversations.RemoveRange(Conversation);
                var infContent = _db.InfulonserContents.Where(p => p.InfulonserId == infulonser.Id).ToList();
                if (infContent.Count != 0) _db.InfulonserContents.RemoveRange(infContent);
                var brand = _db.Brands.Where(p => p.InfulonserId == infulonser.Id).ToList();
                if (brand.Count != 0) _db.Brands.RemoveRange(brand);
                var Post = _db.Posts.Where(p => p.InfulonserId == infulonser.Id).ToList();
               if (Post.Count != 0) _db.Posts.RemoveRange(Post);
               var postInf = _db.PostInfulonsers.Where(p => p.InfulonserId == infulonser.Id).ToList();
                if (postInf.Count != 0) _db.PostInfulonsers.RemoveRange(postInf);
                _db.SaveChanges();
                _db.Infulonsers.Remove(infulonser);
                _db.SaveChanges();
            }
          
        }
        public Infulonser GetInfulonser(int id)
        {
            var infulonser = _db.Infulonsers.First(p=> p.Id==id);
            if (infulonser != null)
                return infulonser;
            else
                return null;
        }
        public void Save(Infulonser infulonser)
        {
            if (infulonser.Id == 0)
            {
                _db.Infulonsers.Add(infulonser);
                _db.SaveChanges();
            }
           
        }
        public void Update(Infulonser infulonser)
        {
            var Infulonser = _db.Infulonsers.First(p => p.Id == infulonser.Id);
            if(Infulonser != null)
            {
                Infulonser.Address = infulonser.Address;
                Infulonser.Description = infulonser.Description;
                Infulonser.Email = infulonser.Email;
                Infulonser.Image = infulonser.Image;
                Infulonser.Name = infulonser.Name;
                Infulonser.Password = infulonser.Password;
                Infulonser.Paypal = infulonser.Paypal;
                Infulonser.Phone = infulonser.Phone;
                Infulonser.UserName = infulonser.UserName;
                _db.SaveChanges();
            }
        }
        public bool IsExisting(string email)
        {
            bool data = _db.Infulonsers.Any(p => p.Email == email);
            if (data == false)
            {
                return false;
            }
            return true;
        }
        public void ChangePassword(int Id,string password )
        {
            var data = _db.Infulonsers.First(p => p.Id ==Id);
            if (data != null)
            {
                data.Password = password;
                _db.SaveChanges();
            }
        }
        public double GetFollowersCount(string email)
        {
            Infulonser infulonser = _db.Infulonsers.FirstOrDefault(p => p.Email == email);
            if (infulonser != null)
            {
                double inf = _db.InfulonserFollowInfulonsers.Where(p => p.FollowedId == infulonser.Id).Count();
                double com = _db.CompanyInfulonsers.Where(p => p.InfulonserId == infulonser.Id && p.Followed == "infulonser").Count();
                double user = _db.InfulonserUsers.Where(p => p.InfulonserId == infulonser.Id).Count();
                return inf + com+user;
            }
            else return -1;
        }
        public List<object> GetFollowers(string email)
        {
            Infulonser infulonser = _db.Infulonsers.FirstOrDefault(p => p.Email == email);
            if (infulonser != null)
            {
                List<object> followers = new List<object>();
                List<InfulonserFollowInfulonser> inf = _db.InfulonserFollowInfulonsers.Where(p => p.FollowedId == infulonser.Id).ToList();
                foreach (InfulonserFollowInfulonser e in inf)
                {
                    Infulonser infAcount = _db.Infulonsers.Where(p => p.Id == e.FollowId).FirstOrDefault();
                    followers.Add(infAcount);
                }
                List<CompanyInfulonser> com = _db.CompanyInfulonsers.Where(p => p.InfulonserId == infulonser.Id && p.Followed == "infulonser").ToList();
                foreach(CompanyInfulonser e in com)
                {
                    Company compAcount = _db.Companies.Where(p => p.Id == e.CompanyId).FirstOrDefault();
                    followers.Add(compAcount);
                }
                List<InfulonserUser> user = _db.InfulonserUsers.Where(p => p.InfulonserId == infulonser.Id).ToList();
                foreach(InfulonserUser e in user)
                {
                    User userAcount = _db.Users.Where(p => p.Id == e.UserId).FirstOrDefault();
                    followers.Add(userAcount);
                }
                return followers;
            }
            else return null;
        }

        public InfulonserWebDto GetInfulonserAll(string email)
        {
            InfulonserWebDto data = new InfulonserWebDto();
            Infulonser infulonser = _db.Infulonsers.FirstOrDefault(p => p.Email == email);
            if (infulonser != null)
            {
                var inf = _db.Infulonsers.Where(p => p.Id == infulonser.Id).SelectMany(t => t.Brand.SelectMany(y => y.Product)).Include(r => r.Brand).ThenInclude(r => r.Product).ToList();
                if (inf.Count != 0)
                {
                    data.Infulonser = infulonser;
                    data.products = inf;
                    return data;
                }
            }
            return null;
        }
    }
}
