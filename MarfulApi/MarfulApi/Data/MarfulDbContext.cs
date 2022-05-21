
using Microsoft.EntityFrameworkCore;
using MarfulApi.Model;
using MarfulApi.Data;


namespace MarfulApi.Data
{
    public class MarfulDbContext: DbContext
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
            modelBuilder.Entity<User>().HasData(new User { Id = 1,Email="test@test.com",Name="Noor", UserName="NonoSy",Phone="0964654765",Age=20,Password="0000",Baybal="Lb1267"});
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Email = "test@test.com", Name = "Ahamad", UserName = "hamodaSy", Phone = "0964654765", Age = 20, Password = "0000", Baybal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Email = "test@test.com", Name = "Tala", UserName = "totoSy", Phone = "0964654765", Age = 20, Password = "0000", Baybal = "Lb1267" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Name="NoorStars",Phone="0965465760",Password="0000",Email="test@test.com",UserName="NoorStars",Address="USA LA",Description="fdsfsgfd",Id=1,Paypal="dskjfhjh" });
        }

    }
}
