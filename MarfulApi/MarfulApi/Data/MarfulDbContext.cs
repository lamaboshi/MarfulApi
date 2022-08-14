
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
        public DbSet<InfulonserFollowInfulonser> InfulonserFollowInfulonsers { get; set; }
        public DbSet<CompanyInfulonser> CompanyInfulonsers { get; set; }
        public DbSet<PostInfulonser> PostInfulonsers { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InfulonserFollowInfulonser>()
                .HasOne(m => m.Follow)
                .WithMany(m => m.Follow)
                .HasForeignKey(m => m.FollowId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<InfulonserFollowInfulonser>()
                .HasOne(x => x.Followed)
                .WithMany(x => x.Followed)
                .HasForeignKey(x => x.FollowedId)
                .OnDelete(DeleteBehavior.NoAction);
           

            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, Name = "JUICY BEAUTY", Description = "JUICY BEAUTY is the place where you can talk about makeup. You can go there for advice from the brand’s makeup artists and cosmetics experts. You can play with new colors and, with the 50 products on display, experiment with new looks and effective makeup products that are tailored to your needs", Address = "From Streat", Email = "JUICYBEAUTY@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 2, Name = "HUDA BEAUTY", Description = "Huda Beauty is a cosmetics line  the brand has a positive reputation on some of its products, such as the popular fake eyelashes series, as well as a collection of foundations, eyeshadows and some face palettes", Address = "From Streat", Email = "hudabeauty@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 3, Name = "MAYBELLINE", Description = "Maybelline, is an American multinational cosmetics, skin care, fragrance, and personal care company, based in New York City. It was founded in Chicago in 1914", Address = "From Streat", Email = "MAYBELLINE@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 4, Name = "LOREAL", Description = "L'Oréal  is a French personal care company headquartered in Clichy, Hauts-de-Seinewith a registered office in Paris. It is the world's largest cosmetics company and has developed activities in the field concentrating on hair color, skin care, sun protection, make-up, perfume, and hair care.", Address = "From Streat", Email = "LOREAL@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 5, Name = "SEPHORA", Description = "Collection ,Sephora offers beauty products including cosmetics, skincare, body, fragrance, nail color, beauty tools, body lotions and haircare.", Address = "From Streat", Email = "SEPHORA@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
           
            modelBuilder.Entity<Company>().HasData(new Company { Id = 6, Name = "ASIC", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 7, Name = "ADDIDAS", Description = "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", Address = "From Streat", Email = "ADDIDAS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 8, Name = "NIKE", Description = "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", Address = "From Streat", Email = "NIKE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 9, Name = "PUMA", Description = "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", Address = "From Streat", Email = "PUMA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 10, Name = "REEBOK", Description = "Asics sponsors a variety of sports associations", Address = "Reebok International Limited (/ˈriːbɒk/) is an American fitness footwear and clothing manufacturer that is a part of Authentic Brands Group.", Email = "REEBOK@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            
            modelBuilder.Entity<Company>().HasData(new Company { Id = 11, Name = "ZARA", Description = "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", Address = "From Streat", Email = "ZARA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 12, Name = "MAX", Description = "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", Address = "From Streat", Email = "MAX@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 13, Name = "MONCLER", Description = "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", Address = "From Streat", Email = "MONCLER@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 14, Name = "LACOSTE", Description = "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", Address = "From Streat", Email = "LACOSTE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 15, Name = "BENETTON", Description = "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", Address = "From Streat", Email = "BENETTON@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
          
            modelBuilder.Entity<Company>().HasData(new Company { Id = 16, Name = "KFC", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "KFC@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 17, Name = "MCDONALDS", Description = "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", Address = "From Streat", Email = "MCDONALDS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 18, Name = "NESTLE", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "NESTLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 19, Name = "STARBUCKS", Description = "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", Address = "From Streat", Email = "STARBUCKS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 20, Name = "PIZZA HUT", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "PIZZAHUT@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 21, Name = "SAMSUNG", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "SAMSUNG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 22, Name = "APPLE", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "APPLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 23, Name = "LG", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "LG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 24, Name = "NETFLIX", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 25, Name = "SHAHED", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
           
            modelBuilder.Entity<Company>().HasData(new Company { Id = 26, Name = "DIOR", Description = "DIOR Products Clothing, cosmetics, fashion accessories, jewelry, perfumes, watches", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 27, Name = "CHANNEL", Description = "Chanel Its products cover clothes, fragrances, handbags and watches", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 28, Name = "GUCCI", Description = "Gucci offers a range of different luxury  Shoes, ready-to-wear apparel, watches, and jewelry are the other main , however they also sell other products such as perfume and home decor", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });

            modelBuilder.Entity<Content>().HasData(new Content { Id = 1, Name = "MackeUp", Description = "All About MakeUp", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 2, Name = "Sports", Description = "All About sports", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 3, Name = "Clothes", Description = "All About Clothes", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 4, Name = "Food", Description = "All About Food", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 5, Name = "Electronics", Description = "All About electronics", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 6, Name = "Platforms", Description = "All About Movies & Series", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 7, Name = "Perfumes", Description = "All About Perfumes", });

            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 1, CompanyId = 1, ContentId = 1 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id =2, CompanyId = 2, ContentId = 2 });

            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 1, Name = "JUICY BEAUTY", Description = "Juicy Beauty was first founded in 2012 in Syria, Damascus. Juicy Beauty was first introduced in Lebanon in 2018.Juicy Beauty is an example of innovation in form due to its display with the largest makeup color made of vibrant and pure pigments and in substancethanks to the exclusive formulas and the revolutionary texture of its makeup products.Behind each product is the excellent research of an expert scientific team that develops new technologies and original formulas.High quality and extreme safety in addition to creativity, taste, and a focus on detail.That’s how JUICY ensures the finest standards of excellence through products that are both gentle and highly effective: Makeup formulas are produced in Europe. The range is subjected to accurate and in-depth safety evaluation.Juicy Beauty is the definition of having fun with makeup, trying new things,and feeling free! Not sure where to start? Why not visit our branches that are all over lebanon and test our products!", CompanyContentId = 1 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 2, Name = "Addidas", Description = "Our company has all kind 0f sport element type", CompanyContentId = 2});

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Email = "user1@test.com", Name = "Noor", UserName = "NonoSy", Phone = "0964654765", Age = 20, Password = "123", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Email = "user2@test.com", Name = "Ahamad", UserName = "hamodaSy", Phone = "0964654765", Age = 20, Password = "456", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Email = "user3@test.com", Name = "Tala", UserName = "totoSy", Phone = "0964654765", Age = 20, Password = "789", Paypal = "Lb1267" });
            
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser {Id=1, Name = "NoorStars", Phone = "0965465760", Password = "0000", Email = "info@test.com", UserName = "NoorStars", Address = "USA LA", Description = "Noor Stars, the first Arabic YouTuber to reach 10 million subscribers, was born in Iraq and grew up in Syria. Having spent her childhood in Damascus, she moved to Turkey for 3 years before moving to the United States with her mother and siblings. She completed her secondary education and university degree, specialising in business administration. Since her channel’s creation in 2014, Noor has posted over 550 videos on her channel, with over 18 million subscribers and 2 billion views in total. She was part of the Maybelline New York's Web series which was named Ramadan stars with Noor Stars and the web series won YouTube's The Lantern award 2019. Noor is best known for her content related to beauty, comics and vlogs.", Paypal = "dskjfhjh" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser {Id=2 ,Name = "Joshua Patterson", Phone = "0965465760", Password = "1111", Email = "Joshua@test.com", UserName = "Joshua", Address = "USA LA", Description = "Joshua Patterson is an actor, known for ER (1994), 7th Heaven (1996) and Weird Science (1994).", Paypal = "dskjffff" });

            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id=1,ContentId=1,InfulonserId=1});
            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 2, ContentId = 2, InfulonserId =2 });

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
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 2, UserId = 2, InfulonserId = 1 });

            modelBuilder.Entity<Post>().HasData(new Post { Id = 1, Description = " test for infulonser post", InfulonserId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 2, Description = " test another post for infulonser", InfulonserId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 3, Description = " test for company post", BrandId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 4, Description = " test another post for company", BrandId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 5, Description = " this is the first post for sport company", BrandId = 2, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 6, Description = " this is the second post for sport company", BrandId = 2, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 7, Description = " Im infulonser with content sport", InfulonserId=2, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 8, Description = " Im infulonser with content sport2", InfulonserId = 2, dateTime = DateTime.Now });



            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 1, InterAction = true, UserId = 1, PostId = 1 });
            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 2, InterAction = false, UserId = 1, PostId = 2 });
            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 3, InterAction = true, UserId = 1, PostId = 4 });

            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 1, FollowId = 2, FollowedId = 1 });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 1, CompanyId = 1, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 2, CompanyId = 1, InfulonserId = 1, Followed = "infulonser" });
        }
    }
}
