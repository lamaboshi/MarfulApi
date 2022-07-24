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
        // get compaines brands
        List<Brand> brandscomp = new List<Brand>();
        // get infulonser brands
        List<Brand> brandinf = new List<Brand>();
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
                        GetCompanyPostBycontent();
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
            foreach (UserCompany e in companies)
            { 
                List<CompanyContent> companyContents = _db.CompanyContents.Where(p => p.CompanyId == e.CompanyId).ToList();
                foreach (CompanyContent n in companyContents)
                {
                    List<Brand> brands = _db.Brands.Where(p => p.CompanyContentId == e.Id).ToList();

                    foreach (Brand b in brands)
                    {
                        List<Post> compposts = _db.Posts.Where(p => p.BrandId == b.Id).ToList();
                        posts.AddRange(compposts);
                    }
                }
            }
        }
        public void GetCompanyPostBycontent()
        {

            foreach (UserCompany e in companies)
            {
                brandscomp = _db.Brands.Where(p => p.CompanyContent.CompanyId == e.CompanyId).ToList();
                foreach (Brand b in brandscomp)
                {
                    List<Post> compPost = _db.Posts.Where(p => p.BrandId == b.Id).ToList();
                    posts.AddRange(compPost);
                }
            }
        }
        public void GetInfulonserPosts()
        {
            foreach (InfulonserUser e in infulonsers)
            {
                List<Post> infposts = _db.Posts.Where(p => p.InfulonserId == e.InfulonserId).Include(r=>r.Infulonser ).ToList();
                posts.AddRange(infposts);
            }
        }
       
        public void GetPostsReaction(List<Post> Posts)
        {
            Company compName = new Company();
            foreach (Post e in Posts)
            {
                PostDto p = new PostDto();
                UserPost userPost = _db.UserPosts.Where(p => p.PostId == e.Id).FirstOrDefault();
                Infulonser infName = _db.Infulonsers.Where(p => p.Id == e.InfulonserId).FirstOrDefault();
                Brand brand = _db.Brands.Where(p => p.Id == e.BrandId).FirstOrDefault();
                if (brand != null)
                {
                    CompanyContent compcontent = _db.CompanyContents.Where(p => p.Id == brand.CompanyContentId).FirstOrDefault();
                    compName = _db.Companies.Where(p => p.Id == compcontent.CompanyId).FirstOrDefault();
                }
                else  compName = null;
                if (userPost != null)
                {
                    if (infName != null)
                    {
                        p.post = e;
                        p.Interaction = userPost.InterAction;
                        p.NoInteraction = false;
                        p.Name = infName.Name;
                        p.Image = infName.Image;
                        postDtos.Add(p);
                    }
                    else if(compName != null)
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
                    if (infName != null)
                    {
                        p.post = e;
                        p.Interaction = false;
                        p.NoInteraction = true;
                        p.Name = infName.Name;
                        p.Image = infName.Image;
                        postDtos.Add(p);
                    }
                    else if(compName != null)
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
