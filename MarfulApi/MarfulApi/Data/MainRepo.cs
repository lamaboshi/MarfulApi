using MarfulApi.Model;
using MarfulApi.Dto;
using MarfulApi.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace MarfulApi.Data
{
    public class MainRepo :IMain
    {
        //for get all posts from com and inf
        List<Post> posts = new List<Post>();
        //for get all posts with interaction 
        List<PostDto> postDtos = new List<PostDto>();
        //get all companies this user follow
        List<UserCompany> companies = new List<UserCompany>();
        //get all infulonser this user follow
        List<InfulonserUser> infulonsers = new List<InfulonserUser>();
       
        private readonly MarfulDbContext _db;
        public MainRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public List<PostDto> GetPost(string email)
        {
            User u = _db.Users.FirstOrDefault(p => p.Email == email);
            if (u != null)
            {
                infulonsers = _db.InfulonserUsers.Where(p => p.UserId == u.Id).ToList();
                companies = _db.UserCompanies.Where(p => p.UserId == u.Id).ToList();
                if (infulonsers.Count == 0 && companies.Count == 0)
                    return null;
                if (companies.Count != 0)
                {
                    GetCompanyPosts();
                }
                if (infulonsers.Count != 0)
                {
                    GetInfulonserPosts();
                }
                if (posts.Count != 0)
                {
                    GetPostsReaction(posts);
                    postDtos.OrderByDescending(p => p.post.dateTime);
                    return postDtos;
                }
                 return null;
            }
            else return null;

        }
        public List<PostDto> GetPostByConent(int IdContent, string email)
        {
            Content content = _db.Contents.FirstOrDefault(p => p.Id == IdContent);
            User user = _db.Users.First(p => p.Email == email);
            if (content != null)
            {
                List<CompanyContent> companyContents = _db.CompanyContents.Where(p => p.ContentId == content.Id).ToList();
                List<InfulonserContent> infulonserContents = _db.InfulonserContents.Where(p => p.ContentId == content.Id).ToList();
                if (companyContents.Count != 0)
                {
                    foreach (CompanyContent e in companyContents)
                    {
                        companies = _db.UserCompanies.Where(p => p.UserId == user.Id && p.CompanyId == e.CompanyId).ToList();
                    }
                    if (companies.Count != 0)
                        GetCompanyPosts();
                }
                if (infulonserContents.Count != 0)
                {
                    foreach (InfulonserContent e in infulonserContents)
                    {
                        infulonsers = _db.InfulonserUsers.Where(p => p.UserId == user.Id && p.InfulonserId == e.InfulonserId).ToList();
                    }
                    if (infulonsers.Count != 0)
                        GetInfulonserPosts();
                }
                if (posts.Count != 0)
                {
                    GetPostsReaction(posts);
                    return postDtos;
                }
                return null;

            }
            else return null;
        }
        public void GetCompanyPosts()
        {
            foreach(UserCompany e in companies)
            {
                var compposts = _db.Companies.Where(p => p.Id == e.CompanyId).SelectMany(p => p.CompanyContent.SelectMany(t => t.Brand.SelectMany(y => y.Post))).Include(r=>r.UserPost).Include(r=>r.Brand).ToList();
                posts.AddRange(compposts);
            }
        }
        
        public void GetInfulonserPosts()
        {
            foreach (InfulonserUser e in infulonsers)
            {
                var infposts = _db.Infulonsers.Where(p => p.Id == e.InfulonserId).SelectMany(p => p.Posts).Include(r=>r.UserPost).Include(r=>r.Infulonser).ToList();
                posts.AddRange(infposts);
            }
        }
       
        public void GetPostsReaction(List<Post> Posts)
        {
            Company compName = new Company();
            foreach (Post e in Posts)
            {
                PostDto p = new PostDto();
                if (e.Brand != null)
                {

                    CompanyContent compcontent = _db.CompanyContents.Where(p => p.Id == e.Brand.CompanyContentId).FirstOrDefault();
                    compName = _db.Companies.Where(p => p.Id == compcontent.CompanyId).FirstOrDefault();
                }
                else compName = null;
                if (e.UserPost.Count != 0)
                {
                    UserPost userPost = _db.UserPosts.Where(p => p.PostId == e.Id).FirstOrDefault();
                    if (e.Infulonser != null)
                    {
                        p.post = e;
                        p.Interaction = userPost.InterAction;
                        p.NoInteraction = false;
                        p.Name = e.Infulonser.Name;
                        p.Image = e.Infulonser.Image;
                        postDtos.Add(p);
                    }
                    else
                    {
                        p.post = e;
                        p.Interaction = userPost.InterAction;
                        p.NoInteraction = false;
                        p.Name = compName.Name;
                        p.Image = compName.Image;
                        postDtos.Add(p);
                    }   
                }
                else
                {
                    if (e.Infulonser != null)
                    {
                        p.post = e;
                        p.Interaction = false;
                        p.NoInteraction = true;
                        p.Name = e.Infulonser.Name;
                        p.Image = e.Infulonser.Image;
                        postDtos.Add(p);
                    }
                    else
                    {
                        p.post = e;
                        p.Interaction = false;
                        p.NoInteraction = true;
                        p.Name = compName.Name;
                        p.Image = compName.Image;
                        postDtos.Add(p);
                    }

                }
            }
        }     
    }
}
