
using Microsoft.EntityFrameworkCore;
using MarfulApi.Model;
using MarfulApi.Data;


namespace MarfulApi.Data
{
    public class MarfulDbContext : DbContext
    {
        public MarfulDbContext(DbContextOptions<MarfulDbContext> options) : base(options)
        {
        }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyContent> CompanyContents { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Infulonser> Infulonsers { get; set; }
        public DbSet<InfulonserContent> InfulonserContents { get; set; }
        public DbSet<InfulonserUser> InfulonserUsers { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserCompany> UserCompanies { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, Name = "JUICY BEAUTY", Description = "MakeUp For Weman", Address = "From Streat", Email = "company1@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 1, Name = "MackeUp", Description = "Just for Weman", });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 1, CompanyId = 1, ContentId = 1 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 1, Name = "JUICY BEAUTY", Description = "Juicy Beauty was first founded in 2012 in Syria, Damascus. Juicy Beauty was first introduced in Lebanon in 2018.Juicy Beauty is an example of innovation in form due to its display with the largest makeup color made of vibrant and pure pigments and in substancethanks to the exclusive formulas and the revolutionary texture of its makeup products.Behind each product is the excellent research of an expert scientific team that develops new technologies and original formulas.High quality and extreme safety in addition to creativity, taste, and a focus on detail.That’s how JUICY ensures the finest standards of excellence through products that are both gentle and highly effective: Makeup formulas are produced in Europe. The range is subjected to accurate and in-depth safety evaluation.Juicy Beauty is the definition of having fun with makeup, trying new things,and feeling free! Not sure where to start? Why not visit our branches that are all over lebanon and test our products!", CompanyContentId = 1 });
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Email = "user1@test.com", Name = "Noor", UserName = "NonoSy", Phone = "0964654765", Age = 20, Password = "123", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Email = "user2@test.com", Name = "Ahamad", UserName = "hamodaSy", Phone = "0964654765", Age = 20, Password = "456", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Email = "user3@test.com", Name = "Tala", UserName = "totoSy", Phone = "0964654765", Age = 20, Password = "789", Paypal = "Lb1267" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Name = "NoorStars", Phone = "0965465760", Password = "0000", Email = "info@test.com", UserName = "NoorStars", Address = "USA LA", Description = "Noor Stars, the first Arabic YouTuber to reach 10 million subscribers, was born in Iraq and grew up in Syria. Having spent her childhood in Damascus, she moved to Turkey for 3 years before moving to the United States with her mother and siblings. She completed her secondary education and university degree, specialising in business administration. Since her channel’s creation in 2014, Noor has posted over 550 videos on her channel, with over 18 million subscribers and 2 billion views in total. She was part of the Maybelline New York's Web series which was named Ramadan stars with Noor Stars and the web series won YouTube's The Lantern award 2019. Noor is best known for her content related to beauty, comics and vlogs.", Id = 1, Paypal = "dskjfhjh" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 3, Name = "Foundation", Price = 350, Description = "This some Text about found", BrandId = 1, Code = "32434" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 4, Name = "CareKream", Price = 290, Description = "This some Text about found", BrandId = 1, Code = "32434" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = 5, Name = "CareSun", Price = 400, Description = "This some Text about found", BrandId = 1, Code = "32434" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 6, Name = "Plasher", Price = 600, Description = "This some Text about found", BrandId = 1, Code = "32434" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 7, Name = "Oclador", Price = 178, Description = "This some Text about found", BrandId = 1, Code = "32434" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 8, Name = "Mascara", Price = 1300, Description = "This some Text about found", BrandId = 1, Code = "32434" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 9, Name = "Tant", Price = 700, Description = "This some Text about found", BrandId = 1, Code = "32434" });
            modelBuilder.Entity<Conversation>().HasData(new Conversation { Id = 1, CompanyId = 1, InfulonserId = 1, Start = DateTime.Now, });
            modelBuilder.Entity<Message>().HasData(new Message { Id = 1, ConversationId = 1, MessageStatus = false, SendTime = DateTime.Now, Text = "hi thanke you very match for this it was nice one" });
            modelBuilder.Entity<Message>().HasData(new Message { Id = 2, ConversationId = 1, MessageStatus = true, SendTime = DateTime.Now, Text = "hi thanke you very match for this it was nice one" });

            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 1, UserId = 1, CompanyId = 1 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 1, UserId = 1, InfulonserId = 1 });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 1, Description = " test for infulonser post", InfulonserId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 2, Description = " test another post for infulonser", InfulonserId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 3, Description = " test for company post", BrandId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 4, Description = " test another post for company", BrandId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 1, InterAction = true, UserId = 1, PostId = 1 });
            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 2, InterAction = false, UserId = 1, PostId = 2 });
            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 3, InterAction = true, UserId = 1, PostId = 4 });

        }
    }
}
