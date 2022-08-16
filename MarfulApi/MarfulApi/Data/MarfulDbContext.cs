
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

            //seeds for company beauty
            modelBuilder.Entity<Company>().HasData(new Company { Id = 1, Name = "JUICY BEAUTY", Description = "JUICY BEAUTY is the place where you can talk about makeup. You can go there for advice from the brand’s makeup artists and cosmetics experts. You can play with new colors and, with the 50 products on display, experiment with new looks and effective makeup products that are tailored to your needs", Address = "From Streat", Email = "JUICYBEAUTY@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 2, Name = "HUDA BEAUTY", Description = "Huda Beauty is a cosmetics line  the brand has a positive reputation on some of its products, such as the popular fake eyelashes series, as well as a collection of foundations, eyeshadows and some face palettes", Address = "From Streat", Email = "hudabeauty@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "12123" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 3, Name = "MAYBELLINE", Description = "Maybelline, is an American multinational cosmetics, skin care, fragrance, and personal care company, based in New York City. It was founded in Chicago in 1914", Address = "From Streat", Email = "MAYBELLINE@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "34345" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 4, Name = "LOREAL", Description = "L'Oréal  is a French personal care company headquartered in Clichy, Hauts-de-Seinewith a registered office in Paris. It is the world's largest cosmetics company and has developed activities in the field concentrating on hair color, skin care, sun protection, make-up, perfume, and hair care.", Address = "From Streat", Email = "LOREAL@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "23234" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 5, Name = "SEPHORA", Description = "Collection ,Sephora offers beauty products including cosmetics, skincare, body, fragrance, nail color, beauty tools, body lotions and haircare.", Address = "From Streat", Email = "SEPHORA@test.com", Phone = "0921423432", TelePhone = "4232543", Password = "45456" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 6, Name = "ASIC", Description = "Asics sponsors a variety of sports associations", Address = "From Streat", Email = "Asics@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 7, Name = "ADDIDAS", Description = "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", Address = "From Streat", Email = "ADDIDAS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 8, Name = "NIKE", Description = "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", Address = "From Streat", Email = "NIKE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "78789" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 9, Name = "PUMA", Description = "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", Address = "From Streat", Email = "PUMA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "67678" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 10, Name = "REEBOK", Description = "Asics sponsors a variety of sports associations", Address = "Reebok International Limited (/ˈriːbɒk/) is an American fitness footwear and clothing manufacturer that is a part of Authentic Brands Group.", Email = "REEBOK@test.com", Phone = "0921423432", TelePhone = "223554", Password = "8989" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 11, Name = "ZARA", Description = "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", Address = "From Streat", Email = "ZARA@test.com", Phone = "0921423432", TelePhone = "223554", Password = "0909" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 12, Name = "MAX", Description = "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", Address = "From Streat", Email = "MAX@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 13, Name = "MONCLER", Description = "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", Address = "From Streat", Email = "MONCLER@test.com", Phone = "0921423432", TelePhone = "223554", Password = "6789" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 14, Name = "LACOSTE", Description = "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", Address = "From Streat", Email = "LACOSTE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 15, Name = "BENETTON", Description = "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", Address = "From Streat", Email = "BENETTON@test.com", Phone = "0921423432", TelePhone = "223554", Password = "9463" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 16, Name = "KFC", Description = "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", Address = "Louisville, KentuckyFrom Streat", Email = "KFC@test.com", Phone = "0921423432", TelePhone = "223554", Password = "5252" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 17, Name = "MCDONALDS", Description = "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", Address = "From Streat", Email = "MCDONALDS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "99999" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 18, Name = "NESTLE", Description = "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", Address = "From Streat", Email = "NESTLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 19, Name = "STARBUCKS", Description = "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", Address = "From Streat", Email = "STARBUCKS@test.com", Phone = "0921423432", TelePhone = "223554", Password = "123122" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 20, Name = "PIZZA HUT", Description = "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", Address = "From Streat", Email = "PIZZAHUT@test.com", Phone = "0921423432", TelePhone = "223554", Password = "34345" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 21, Name = "SAMSUNG", Description = " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", Address = "Suwon, South Korea", Email = "SAMSUNG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "111222" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 22, Name = "APPLE", Description = "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", Address = "Cupertino, California, United States", Email = "APPLE@test.com", Phone = "0921423432", TelePhone = "223554", Password = "77666" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 23, Name = "LG", Description = "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", Address = "South Korea", Email = "LG@test.com", Phone = "0921423432", TelePhone = "223554", Password = "989887" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 24, Name = "NETFLIX", Description = "Netflix is   an American entertainment company that specializes in providing live broadcasting, video-on-demand, and mail-delivery of CDs. Netflix has expanded into the production of films and television shows, and online video distribution", Address = " Los Gatos, California", Email = "NETFLIX@test.com", Phone = "0921423432", TelePhone = "223554", Password = "34567" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 25, Name = "SHAHID", Description = "Shahid is the first Arab platform to provide \"Video on Demand\" service in the Middle East, and it has been re-launched by the \"MBC\" media group.  It is worth noting that Shahid,the leading subscription video-on-demand platform, is considered the leading Arab broadcasting platform in the world and the home of original Arabic productions with world-class specifications.along with a live broadcast of a group of the most watched Arab TV channels", Address = "From Streat", Email = "SHAHID@test.com", Phone = "0921423432", TelePhone = "223554", Password = "888877" });

            modelBuilder.Entity<Company>().HasData(new Company { Id = 26, Name = "DIOR", Description = "DIOR Products Clothing, cosmetics, fashion accessories, jewelry, perfumes, watches", Address = "From Streat", Email = "DIOR@test.com", Phone = "0921423432", TelePhone = "223554", Password = "777776" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 27, Name = "CHANNEL", Description = "Chanel Its products cover clothes, fragrances, handbags and watches", Address = "From Streat", Email = "CHANNEL@test.com", Phone = "0921423432", TelePhone = "223554", Password = "333333" });
            modelBuilder.Entity<Company>().HasData(new Company { Id = 28, Name = "GUCCI", Description = "Gucci offers a range of different luxury  Shoes, ready-to-wear apparel, watches, and jewelry are the other main , however they also sell other products such as perfume and home decor", Address = "From Streat", Email = "Gucci@test.com", Phone = "0921423432", TelePhone = "223554", Password = "8888882" });

            modelBuilder.Entity<Content>().HasData(new Content { Id = 1, Name = "MackeUp", Description = "All About MakeUp", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 2, Name = "Sports", Description = "All About sports", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 3, Name = "Clothes", Description = "All About Clothes", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 4, Name = "Food", Description = "All About Food", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 5, Name = "Electronics", Description = "All About electronics", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 6, Name = "Platforms", Description = "All About Movies & Series", });
            modelBuilder.Entity<Content>().HasData(new Content { Id = 7, Name = "Perfumes", Description = "All About Perfumes", });

            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 1, CompanyId = 1, ContentId = 1 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 2, CompanyId = 2, ContentId = 1 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 3, CompanyId = 3, ContentId = 1 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 4, CompanyId = 4, ContentId = 1 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 5, CompanyId = 5, ContentId = 1 });

            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 6, CompanyId = 6, ContentId = 2 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 7, CompanyId = 7, ContentId = 2 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 8, CompanyId = 8, ContentId = 2 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 9, CompanyId = 9, ContentId = 2 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 10, CompanyId = 10, ContentId = 2 });

            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 11, CompanyId = 11, ContentId = 3 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 12, CompanyId = 12, ContentId = 3 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 13, CompanyId = 13, ContentId = 3 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 14, CompanyId = 14, ContentId = 3 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 15, CompanyId = 15, ContentId = 3 });

            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 16, CompanyId = 16, ContentId = 4 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 17, CompanyId = 17, ContentId = 4 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 18, CompanyId = 18, ContentId = 4 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 19, CompanyId = 19, ContentId = 4 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 20, CompanyId = 20, ContentId = 4 });

            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 21, CompanyId = 21, ContentId = 5 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 22, CompanyId = 22, ContentId = 5 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 23, CompanyId = 23, ContentId = 5 });

            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 24, CompanyId = 24, ContentId = 6 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 25, CompanyId = 25, ContentId = 6 });

            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 26, CompanyId = 26, ContentId = 7 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 27, CompanyId = 27, ContentId = 7 });
            modelBuilder.Entity<CompanyContent>().HasData(new CompanyContent { Id = 28, CompanyId = 28, ContentId = 7 });

            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 1, Name = "JUICY BEAUTY", Description = "Juicy Beauty was first founded in 2012 in Syria, Damascus. Juicy Beauty was first introduced in Lebanon in 2018.Juicy Beauty is an example of innovation in form due to its display with the largest makeup color made of vibrant and pure pigments and in substancethanks to the exclusive formulas and the revolutionary texture of its makeup products.Behind each product is the excellent research of an expert scientific team that develops new technologies and original formulas.High quality and extreme safety in addition to creativity, taste, and a focus on detail.That’s how JUICY ensures the finest standards of excellence through products that are both gentle and highly effective: Makeup formulas are produced in Europe. The range is subjected to accurate and in-depth safety evaluation.Juicy Beauty is the definition of having fun with makeup, trying new things,and feeling free! Not sure where to start? Why not visit our branches that are all over lebanon and test our products!", CompanyContentId = 1 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 2, Name = "HUDA BEAUTY", Description = "Huda Beauty is a cosmetics line  the brand has a positive reputation on some of its products, such as the popular fake eyelashes series, as well as a collection of foundations, eyeshadows and some face palettes", CompanyContentId = 2 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 3, Name = "MAYBELLINE", Description = "Maybelline, is an American multinational cosmetics, skin care, fragrance, and personal care company, based in New York City. It was founded in Chicago in 1914", CompanyContentId = 3 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 4, Name = "LOREAL", Description = "L'Oréal  is a French personal care company headquartered in Clichy, Hauts-de-Seinewith a registered office in Paris. It is the world's largest cosmetics company and has developed activities in the field concentrating on hair color, skin care, sun protection, make-up, perfume, and hair care.", CompanyContentId = 4 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 5, Name = "SEPHORA", Description = "Collection ,Sephora offers beauty products including cosmetics, skincare, body, fragrance, nail color, beauty tools, body lotions and haircare.", CompanyContentId = 5 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 6, Name = "ASIC", Description = "Asics sponsors a variety of sports associations", CompanyContentId = 6});
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 7, Name = "ADDIDAS", Description = "Manufacturer of sports shoes and apparel. It was the largest sportswear manufacturer in Europe and the second largest after Nike in the world. Adidas products are traditionally distinguished by a three-line brand, which remains an element of the company's latest products", CompanyContentId = 7 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 8, Name = "NIKE", Description = "The world’s largest athletic apparel company, Nike is best known for its footwear, apparel, and equipment. One of the most valuable brands among sport businesses,The company sponsors top athletes and sports teams around the world.", CompanyContentId = 8});
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 9, Name = "PUMA", Description = "Puma, is a German multinational corporation that designs and manufactures athletic and casual footwear, apparel and accessories, which is headquartered in Herzogenaurach, Bavaria, Germany. Puma is the third largest sportswear manufacturer in the world", CompanyContentId = 9 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 10, Name = "REEBOK", Description = "Asics sponsors a variety of sports associations", CompanyContentId = 10});
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 11, Name = "ZARA", Description = "A clothing retailer, the company specializes in fast fashion, and its products include apparel, accessories, footwear, swimwear, cosmetics, and perfume. It is one of the largest clothing retailers in the world which also includes brands such as Bershka and Massimo Dutti.", CompanyContentId = 11});
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 12, Name = "MAX", Description = "Max Fashion is an Indian fashion brand under the banner of the Landmark Group in Dubai", CompanyContentId = 12 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 13, Name = "MONCLER", Description = "It is an Italian luxury fashion house specializing in ready-to-wear and haute couture, headquartered in Milan, Italy. Expanded to design raincoats, windbreakers, knitwear, leather goods, shoes, perfume, and accessories", CompanyContentId = 13 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 14, Name = "LACOSTE", Description = "Lacoste S.A. is a French company. It sells clothing, footwear, sportswear, eyewear, leather goods, perfume, towels and watches", CompanyContentId = 14 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 15, Name = "BENETTON", Description = "It is one of the most famous fashion companies in the world. The group enjoys a unified identity consisting of colours, authentic fashion and quality at democratic prices", CompanyContentId = 15 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 16, Name = "KFC", Description = "Kentucky Fried Chicken or KFC is a chain of fast food restaurants that specializes primarily in fried chicken.  It is the second largest chain of fast food restaurants in the world in terms of sales after McDonald's. Kentucky Fried Chicken has nearly twenty thousand branches spread over 123 countries and territories around the world.", CompanyContentId = 16 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 17, Name = "MCDONALDS", Description = "MCDONALD'S is the world's largest restaurant chain by revenue,McDonald's is best known for its hamburgers, cheeseburgers and french fries, although their menus include other items like chicken, fish, fruit, and salads", CompanyContentId = 17 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 18, Name = "NESTLE", Description = "Nestlé is a multinational company specializing in the production of canned foods, founded in Vevey, Switzerland.", CompanyContentId = 18 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 19, Name = "STARBUCKS", Description = "STARBUCKS is a specialty coffee retailer. It roasts, markets, and retails specialty coffee. The company, through its stores, offers several blends of coffee, handcrafted beverages, merchandise, and food items", CompanyContentId = 19 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 20, Name = "PIZZA HUT", Description = "Pizza Hut is an American multinational restaurant chain and international franchise founded in 1958 in Wichita, Kansas by Dan and Frank Carney. They serve their signature pan pizza and other dishes including pasta, breadsticks and desserts.", CompanyContentId = 20 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 21, Name = "SAMSUNG", Description = " Samsung Electronics is the world's largest electronics and information technology company.  Samsung Electronics is part of the Samsung Group, which is the largest conglomerate in South Korea and the global market leader with more than 60 products including semiconductors such as DRAM and flash memory, digital display devices such as liquid crystal TVs  LCD and plasma, consumer electronics such as DVD players, mobile phones, digital cameras and laser printers, household appliances such as refrigerators, microwaves and dishwashers.", CompanyContentId = 21 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 22, Name = "APPLE", Description = "The Apple Corporation is an American multinational technology company specializing in consumer electronics, software and online services.  It is one of the top five American IT companies", CompanyContentId = 22 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 23, Name = "LG", Description = "The Korean LG Group this company is the second largest holding company, producing electronics, chemicals and telecommunications products.  from 80 countries", CompanyContentId = 23 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 24, Name = "NETFLIX", Description = "Netflix is   an American entertainment company that specializes in providing live broadcasting, video-on-demand, and mail-delivery of CDs. Netflix has expanded into the production of films and television shows, and online video distribution", CompanyContentId = 24 });
            modelBuilder.Entity<Brand>().HasData(new Brand { Id = 25, Name = "SHAHID", Description = "Shahid is the first Arab platform to provide \"Video on Demand\" service in the Middle East, and it has been re-launched by the \"MBC\" media group.  It is worth noting that Shahid,the leading subscription video-on-demand platform, is considered the leading Arab broadcasting platform in the world and the home of original Arabic productions with world-class specifications.along with a live broadcast of a group of the most watched Arab TV channels", CompanyContentId = 25 });




            modelBuilder.Entity<User>().HasData(new User { Id = 1, Email = "Hadel@test.com", Name = "Hadel Dabbas", UserName = "hadel2000", Phone = "0964654765", Age = 20, Password = "123", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Email = "Asia@test.com", Name = "Asia", UserName = "Asel", Phone = "0964654765", Age = 20, Password = "456", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Email = "yousfi@test.com", Name = "Haya Yousfi", UserName = "Haya", Phone = "0964654765", Age = 20, Password = "789", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 4, Email = "Eid@test.com", Name = "Haya Eid", UserName = "HayaSy", Phone = "0964654765", Age = 20, Password = "101", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 5, Email = "lama@test.com", Name = "Lama Boshi", UserName = "Lamaz", Phone = "0964654765", Age = 20, Password = "121", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 6, Email = "Hamzeh@test.com", Name = "Hamze Badinjky", UserName = "hamzehS", Phone = "0964654765", Age = 20, Password = "141", Paypal = "Lb1267" });
            modelBuilder.Entity<User>().HasData(new User { Id = 7, Email = "Adam@test.com", Name = "Adam Syria", UserName = "Adom", Phone = "0964654765", Age = 20, Password = "161", Paypal = "Lb1267" });

            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Id = 1, Name = "NoorStars", Phone = "0965465760", Password = "0000", Email = "info@test.com", UserName = "NoorStars", Address = "USA LA", Description = "Noor Stars, the first Arabic YouTuber to reach 10 million subscribers, was born in Iraq and grew up in Syria. Having spent her childhood in Damascus, she moved to Turkey for 3 years before moving to the United States with her mother and siblings. She completed her secondary education and university degree, specialising in business administration. Since her channel’s creation in 2014, Noor has posted over 550 videos on her channel, with over 18 million subscribers and 2 billion views in total. She was part of the Maybelline New York's Web series which was named Ramadan stars with Noor Stars and the web series won YouTube's The Lantern award 2019. Noor is best known for her content related to beauty, comics and vlogs.", Paypal = "dskjfhjh" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Id = 2, Name = "Joshua Patterson", Phone = "0965465760", Password = "1111", Email = "Joshua@test.com", UserName = "Joshua", Address = "USA LA", Description = "Joshua Patterson is an actor, known for ER (1994), 7th Heaven (1996) and Weird Science (1994).", Paypal = "dskjffff" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Id = 3, Name = "Ossy Marwah", Phone = "0965465760", Password = "2222", Email = "Ossy@test.com", UserName = "Ossy", Address = "Dubai/Los Angeles", Description = "You Tuber/Content Creator", Paypal = "dskjffff" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Id = 4, Name = "Ibrahim Almarrawi", Phone = "0965465760", Password = "3333", Email = "barhom@test.com", UserName = "barhom", Address = "DUBAI", Description = "Critic/You Tuber", Paypal = "dskjffff" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Id = 5, Name = "Feras Abo Shaar", Phone = "0965465760", Password = "4444", Email = "feras@test.com", UserName = "Feras", Address = "Dubia,United Arab Emirates", Description = "foodblogger/cars/travel", Paypal = "dskjffff" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Id = 6, Name = "Kareem Deeb", Phone = "0965465760", Password = "5555", Email = "kareem@test.com", UserName = "Deeb", Address = "Dubia/London", Description = "The Guy Who Drove Your Dream Car", Paypal = "dskjffff" });
            modelBuilder.Entity<Infulonser>().HasData(new Infulonser { Id = 7, Name = "Leen AbouShaar", Phone = "0965465760", Password = "6666", Email = "Leen@test.com", UserName = "Leen", Address = "Syria", Description = "journalist & Presenter @mbc1", Paypal = "dskjffff" });

            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 1, ContentId = 1, InfulonserId = 1 });
            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 2, ContentId = 1, InfulonserId = 7 });

            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 3, ContentId = 2, InfulonserId = 2 });
            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 4, ContentId = 2, InfulonserId = 5 });

            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 5, ContentId = 3, InfulonserId = 7 });
            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 6, ContentId = 3, InfulonserId = 4 });

            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 7, ContentId = 4, InfulonserId = 6 });

            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 8, ContentId = 5, InfulonserId = 2 });
            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 9, ContentId = 5, InfulonserId = 3 });

            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 10, ContentId = 6, InfulonserId = 1 });
            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 11, ContentId = 6, InfulonserId = 4 });

            modelBuilder.Entity<InfulonserContent>().HasData(new InfulonserContent { Id = 12, ContentId = 7, InfulonserId = 7 });

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
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 2, UserId = 1, CompanyId = 2 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 3, UserId = 1, CompanyId = 3 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 4, UserId = 1, CompanyId = 4 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 5, UserId = 1, CompanyId = 5 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 6, UserId = 1, CompanyId = 6 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 7, UserId = 1, CompanyId = 7 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 8, UserId = 1, CompanyId = 8 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 9, UserId = 1, CompanyId = 9 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 10, UserId = 1, CompanyId = 10 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 11, UserId = 1, CompanyId = 11 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 12, UserId = 1, CompanyId = 12 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 13, UserId = 1, CompanyId = 13 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 14, UserId = 1, CompanyId = 14 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 15, UserId = 1, CompanyId = 15 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 16, UserId = 1, CompanyId = 16 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 17, UserId = 1, CompanyId = 17 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 18, UserId = 1, CompanyId = 18 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 19, UserId = 1, CompanyId = 19 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 20, UserId = 1, CompanyId = 20 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 21, UserId = 1, CompanyId = 21 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 22, UserId = 1, CompanyId = 22 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 23, UserId = 1, CompanyId = 23 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 24, UserId = 1, CompanyId = 24 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 25, UserId = 1, CompanyId = 25 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 26, UserId = 1, CompanyId = 26 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 27, UserId = 1, CompanyId = 27 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 28, UserId = 1, CompanyId = 28 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 29, UserId = 2, CompanyId = 1 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 30, UserId = 2, CompanyId = 2 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 31, UserId = 2, CompanyId = 3 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 32, UserId = 2, CompanyId = 4 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 33, UserId = 2, CompanyId = 5 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 34, UserId = 2, CompanyId = 24 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 35, UserId = 2, CompanyId = 25 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 36, UserId = 2, CompanyId = 21 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 37, UserId = 2, CompanyId = 22 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 38, UserId = 2, CompanyId = 23 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 39, UserId = 2, CompanyId = 6 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 40, UserId = 2, CompanyId = 7 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 41, UserId = 2, CompanyId = 8 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 42, UserId = 2, CompanyId = 9 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 43, UserId = 2, CompanyId = 10 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 44, UserId = 2, CompanyId = 11 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 45, UserId = 2, CompanyId = 12 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 46, UserId = 2, CompanyId = 13 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 47, UserId = 2, CompanyId = 14 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 48, UserId = 2, CompanyId = 15 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 49, UserId = 2, CompanyId = 26 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 50, UserId = 2, CompanyId = 27 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 51, UserId = 2, CompanyId = 28 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 52, UserId = 3, CompanyId = 16 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 53, UserId = 3, CompanyId = 17 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 54, UserId = 3, CompanyId = 18 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 55, UserId = 3, CompanyId = 19 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 56, UserId = 3, CompanyId = 20 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 57, UserId = 3, CompanyId = 24 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 58, UserId = 3, CompanyId = 25 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 44, UserId = 3, CompanyId = 11 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 45, UserId = 3, CompanyId = 12 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 46, UserId = 3, CompanyId = 13 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 47, UserId = 3, CompanyId = 14 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 48, UserId = 3, CompanyId = 15 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 49, UserId = 3, CompanyId = 6 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 50, UserId = 3, CompanyId = 7 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 51, UserId = 3, CompanyId = 8 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 52, UserId = 3, CompanyId = 9 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 53, UserId = 3, CompanyId = 10 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 54, UserId = 4, CompanyId = 1 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 55, UserId = 4, CompanyId = 2 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 56, UserId = 4, CompanyId = 3 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 57, UserId = 4, CompanyId = 4 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 58, UserId = 4, CompanyId = 5 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 59, UserId = 4, CompanyId = 24 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 60, UserId = 4, CompanyId = 25 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 61, UserId = 4, CompanyId = 6 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 62, UserId = 4, CompanyId = 7 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 63, UserId = 4, CompanyId = 8 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 64, UserId = 4, CompanyId = 9 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 65, UserId = 4, CompanyId = 10 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 66, UserId = 4, CompanyId = 21 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 67, UserId = 4, CompanyId = 22});
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 68, UserId = 4, CompanyId = 23});
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 69, UserId = 5, CompanyId = 11 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 70, UserId = 5, CompanyId = 12 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 71, UserId = 5, CompanyId = 13 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 72, UserId = 5, CompanyId = 14 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 73, UserId = 5, CompanyId = 15 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 74, UserId = 5, CompanyId = 24 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 75, UserId = 5, CompanyId = 25 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 76, UserId = 5, CompanyId = 6 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 77, UserId = 5, CompanyId = 7 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 78, UserId = 5, CompanyId = 8 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 79, UserId = 5, CompanyId = 9 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 80, UserId = 5, CompanyId = 10 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 81, UserId = 5, CompanyId = 22 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 82, UserId = 5, CompanyId = 23});
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 83, UserId = 5, CompanyId = 24});
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 84, UserId = 6, CompanyId = 1 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 85, UserId = 6, CompanyId = 2 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 86, UserId = 6, CompanyId = 3 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 87, UserId = 6, CompanyId = 4 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 88, UserId = 6, CompanyId = 5 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 89, UserId = 6, CompanyId = 6 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 90, UserId = 6, CompanyId = 7 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 91, UserId = 6, CompanyId = 8 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 92, UserId = 6, CompanyId = 9 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 93, UserId =6, CompanyId = 10 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 94, UserId = 6, CompanyId = 11 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 95, UserId = 6, CompanyId = 12 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 96, UserId = 6, CompanyId = 13 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 97, UserId = 6, CompanyId = 14 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 98, UserId = 6, CompanyId = 15 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 99, UserId = 6, CompanyId = 16 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 100, UserId = 6, CompanyId = 17 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 101, UserId = 6, CompanyId = 18 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 102, UserId = 6, CompanyId = 19 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 103, UserId = 6, CompanyId = 20 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 104, UserId = 6, CompanyId = 21 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 105, UserId = 6, CompanyId = 22 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 106, UserId = 6, CompanyId = 23 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 107, UserId = 6, CompanyId = 24 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 108, UserId = 6, CompanyId = 25 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 109, UserId = 6, CompanyId = 26 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 110, UserId = 6, CompanyId = 27 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 111, UserId = 6, CompanyId = 28 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 112, UserId = 7, CompanyId = 21 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 113, UserId = 7, CompanyId = 22 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 114, UserId = 7, CompanyId = 23 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 115, UserId = 7, CompanyId = 11 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 116, UserId = 7, CompanyId = 12 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 117, UserId = 7, CompanyId = 13 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 118, UserId = 7, CompanyId = 14 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 119, UserId = 7, CompanyId = 15 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 120, UserId = 7, CompanyId = 24 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 121, UserId = 7, CompanyId = 25 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 122, UserId = 7, CompanyId = 6 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 123, UserId = 7, CompanyId = 7 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 124, UserId = 7, CompanyId = 8 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 125, UserId = 7, CompanyId = 9 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 126, UserId = 7, CompanyId = 10 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 127, UserId = 7, CompanyId = 16 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 128, UserId = 7, CompanyId = 17 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 129, UserId = 7, CompanyId = 18 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 130, UserId = 7, CompanyId = 19 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 131, UserId = 7, CompanyId = 20 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 132, UserId = 7, CompanyId = 1});
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 133, UserId = 7, CompanyId = 2 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 134, UserId = 7, CompanyId = 3 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 135, UserId = 7, CompanyId = 4 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 136, UserId = 7, CompanyId = 5 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 137, UserId = 7, CompanyId = 26 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 138, UserId = 7, CompanyId = 27 });
            modelBuilder.Entity<UserCompany>().HasData(new UserCompany { Id = 139, UserId = 7, CompanyId = 28 });

            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 1, UserId = 1, InfulonserId = 1 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 2, UserId = 1, InfulonserId = 2 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 3, UserId = 1, InfulonserId = 3 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 4, UserId = 1, InfulonserId = 5 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 5, UserId = 1, InfulonserId = 6});
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 6, UserId = 1, InfulonserId = 7 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 7, UserId = 2, InfulonserId = 1 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 8, UserId = 2, InfulonserId = 3 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 9, UserId = 2, InfulonserId = 5 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 10, UserId = 2, InfulonserId = 7 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 11, UserId = 3, InfulonserId = 2 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 12, UserId = 3, InfulonserId = 4 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 13, UserId = 3, InfulonserId = 6 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 14, UserId = 4, InfulonserId = 1 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 15, UserId = 4, InfulonserId = 2 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 16, UserId = 4, InfulonserId = 3 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 17, UserId = 5, InfulonserId = 4 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 18, UserId = 5, InfulonserId = 5 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 19, UserId = 5, InfulonserId = 6});
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 20, UserId = 6, InfulonserId = 1 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 21, UserId = 6, InfulonserId = 2 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 22, UserId = 6, InfulonserId = 3 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 23, UserId = 6, InfulonserId = 5 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 24, UserId = 6, InfulonserId = 6 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 25, UserId = 7, InfulonserId = 3 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 26, UserId = 7, InfulonserId = 4 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 27, UserId = 7, InfulonserId = 5 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 28, UserId = 7, InfulonserId = 6 });
            modelBuilder.Entity<InfulonserUser>().HasData(new InfulonserUser { Id = 29, UserId = 7, InfulonserId = 7 });
            



            modelBuilder.Entity<Post>().HasData(new Post { Id = 1, Description = " test for infulonser post", InfulonserId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 2, Description = " test another post for infulonser", InfulonserId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 3, Description = " test for company post", BrandId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 4, Description = " test another post for company", BrandId = 1, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 5, Description = " this is the first post for sport company", BrandId = 2, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 6, Description = " this is the second post for sport company", BrandId = 2, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 7, Description = " Im infulonser with content sport", InfulonserId = 2, dateTime = DateTime.Now });
            modelBuilder.Entity<Post>().HasData(new Post { Id = 8, Description = " Im infulonser with content sport2", InfulonserId = 2, dateTime = DateTime.Now });



            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 1, InterAction = true, UserId = 1, PostId = 1 });
            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 2, InterAction = false, UserId = 1, PostId = 2 });
            modelBuilder.Entity<UserPost>().HasData(new UserPost { Id = 3, InterAction = true, UserId = 1, PostId = 4 });

            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 1, FollowId = 1, FollowedId = 2 });
            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 2, FollowId = 2, FollowedId = 1 });
            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 3, FollowId = 2, FollowedId = 3 });
            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 4, FollowId = 3, FollowedId = 4 });
            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 5, FollowId = 4, FollowedId = 5 });
            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 6, FollowId = 5, FollowedId = 4 });
            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 7, FollowId = 6, FollowedId = 7 });
            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 8, FollowId = 7, FollowedId = 6 });
            modelBuilder.Entity<InfulonserFollowInfulonser>().HasData(new InfulonserFollowInfulonser { Id = 9, FollowId = 7, FollowedId = 1 });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 1, CompanyId = 1, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 2, CompanyId = 2, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 3, CompanyId = 3, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 4, CompanyId = 4, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 5, CompanyId = 5, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 6, CompanyId = 11, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 7, CompanyId = 15, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 8, CompanyId = 22, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 9, CompanyId = 18, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 10, CompanyId = 24, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 11, CompanyId = 26, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 12, CompanyId = 27, InfulonserId = 1, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 13, CompanyId = 28, InfulonserId = 1, Followed = "company" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 14, CompanyId = 1, InfulonserId = 7, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 15, CompanyId = 2, InfulonserId = 7, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 16, CompanyId = 5, InfulonserId = 7, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 17, CompanyId = 11, InfulonserId = 7, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 18, CompanyId = 12, InfulonserId = 7, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 19, CompanyId = 15, InfulonserId = 7, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 20, CompanyId = 26, InfulonserId = 7, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 21, CompanyId = 25, InfulonserId = 7, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 22, CompanyId = 22, InfulonserId = 7, Followed = "company" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 23, CompanyId = 16, InfulonserId = 6, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 24, CompanyId = 17, InfulonserId = 6, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 25, CompanyId = 18, InfulonserId = 6, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 26, CompanyId = 19, InfulonserId = 6, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 27, CompanyId = 20, InfulonserId = 6, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 28, CompanyId = 21, InfulonserId = 6, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 29, CompanyId = 22, InfulonserId = 6, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 30, CompanyId = 23, InfulonserId = 6, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 31, CompanyId = 15, InfulonserId = 6, Followed = "company" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 32, CompanyId = 6, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 33, CompanyId = 7, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 34, CompanyId = 8, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 35, CompanyId = 9, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 36, CompanyId = 10, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 37, CompanyId = 11, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 38, CompanyId = 12, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 39, CompanyId = 13, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 40, CompanyId = 14, InfulonserId = 2, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 41, CompanyId = 15, InfulonserId = 2, Followed = "company" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 42, CompanyId = 21, InfulonserId = 3, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 43, CompanyId = 22, InfulonserId = 3, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 44, CompanyId = 23, InfulonserId = 3, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 45, CompanyId = 24, InfulonserId = 3, Followed = "company" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 46, CompanyId = 25, InfulonserId = 4, Followed = "company" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 47, CompanyId = 3, InfulonserId = 5, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 48, CompanyId = 10, InfulonserId = 5, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 49, CompanyId = 14, InfulonserId = 5, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 50, CompanyId = 18, InfulonserId = 5, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 51, CompanyId = 22, InfulonserId = 5, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 52, CompanyId = 24, InfulonserId = 5, Followed = "company" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 53, CompanyId = 28, InfulonserId = 5, Followed = "company" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 54, CompanyId = 1, InfulonserId = 1, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 55, CompanyId = 1, InfulonserId = 7, Followed = "infulonser" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 56, CompanyId = 2, InfulonserId = 1, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 57, CompanyId = 3, InfulonserId = 7, Followed = "infulonser" });

            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 58, CompanyId = 4, InfulonserId = 7, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 59, CompanyId = 5, InfulonserId = 1, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 60, CompanyId = 6, InfulonserId = 2, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 61, CompanyId = 7, InfulonserId = 2, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 62, CompanyId = 8, InfulonserId = 5, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 63, CompanyId = 9, InfulonserId = 5, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 64, CompanyId = 10, InfulonserId = 2, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 65, CompanyId = 11, InfulonserId = 7, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 66, CompanyId = 12, InfulonserId = 4, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 67, CompanyId = 13, InfulonserId = 7, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 68, CompanyId = 14, InfulonserId = 4, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 69, CompanyId = 15, InfulonserId = 7, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 70, CompanyId = 16, InfulonserId = 6, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 71, CompanyId = 17, InfulonserId = 6, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 72, CompanyId = 18, InfulonserId = 6, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 73, CompanyId = 19, InfulonserId = 4, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 74, CompanyId = 20, InfulonserId = 6, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 75, CompanyId = 20, InfulonserId = 2, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 76, CompanyId = 20, InfulonserId = 3, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 77, CompanyId = 21, InfulonserId = 3, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 78, CompanyId = 22, InfulonserId = 2, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 79, CompanyId = 23, InfulonserId = 3, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 80, CompanyId = 26, InfulonserId = 7, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 81, CompanyId = 27, InfulonserId = 6, Followed = "infulonser" });
            modelBuilder.Entity<CompanyInfulonser>().HasData(new CompanyInfulonser { Id = 82, CompanyId = 28, InfulonserId = 3, Followed = "infulonser" });

            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 1, CompanyId = 1,type= "chat employee",Password= "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 2, CompanyId = 1, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 3, CompanyId = 1, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 4, CompanyId = 1, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 5, CompanyId = 2, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 6, CompanyId = 2, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 7, CompanyId = 2, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 8, CompanyId = 2, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 9, CompanyId = 3, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 10, CompanyId = 3, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 11, CompanyId = 3, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 12, CompanyId = 3, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 13, CompanyId = 4, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 14, CompanyId = 4, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 15, CompanyId = 4, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 16, CompanyId = 4, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 17, CompanyId = 5, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 18, CompanyId = 5, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 19, CompanyId = 5, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 20, CompanyId = 5, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 21, CompanyId = 6, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 22, CompanyId = 6, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 23, CompanyId = 6, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 24, CompanyId = 6, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 25, CompanyId = 7, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 26, CompanyId = 7, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 27, CompanyId = 7, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 28, CompanyId = 7, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 29, CompanyId = 8, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 30, CompanyId = 8, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 31, CompanyId = 8, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 32, CompanyId = 8, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 33, CompanyId = 9, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 34, CompanyId = 9, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 35, CompanyId = 9, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 36, CompanyId = 9, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 37, CompanyId = 10, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 38, CompanyId = 10, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 39, CompanyId = 10, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 40, CompanyId = 10, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 41, CompanyId = 11, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 42, CompanyId = 11, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 43, CompanyId = 11, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 44, CompanyId = 11, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 45, CompanyId = 12, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 46, CompanyId = 12, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 47, CompanyId = 12, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 48, CompanyId = 12, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 49, CompanyId = 13, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 50, CompanyId = 13, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 51, CompanyId = 13, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 52, CompanyId = 13, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 53, CompanyId = 14, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 54, CompanyId = 14, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 55, CompanyId = 14, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 56, CompanyId = 14, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 57, CompanyId = 15, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 58, CompanyId = 15, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 59, CompanyId = 15, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 60, CompanyId = 15, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 61, CompanyId = 16, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 62, CompanyId = 16, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 63, CompanyId = 16, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 64, CompanyId = 16, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 65, CompanyId = 17, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 66, CompanyId = 17, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 67, CompanyId = 17, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 68, CompanyId = 17, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 69, CompanyId = 18, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 70, CompanyId = 18, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 71, CompanyId = 18, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 72, CompanyId = 18, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 72, CompanyId = 19, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 73, CompanyId = 19, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 74, CompanyId = 19, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 75, CompanyId = 19, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 76, CompanyId = 20, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 77, CompanyId = 20, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 78, CompanyId = 20, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 79, CompanyId = 20, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 80, CompanyId = 21, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 81, CompanyId = 21, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 82, CompanyId = 21, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 83, CompanyId = 21, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 84, CompanyId = 22, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 85, CompanyId = 22, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 86, CompanyId = 22, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 87, CompanyId = 22, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 88, CompanyId = 23, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 89, CompanyId = 23, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 90, CompanyId = 23, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 91, CompanyId = 23, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 92, CompanyId = 24, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 93, CompanyId = 24, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 94, CompanyId = 24, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 95, CompanyId = 24, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 96, CompanyId = 25, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 97, CompanyId = 25, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 98, CompanyId = 25, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 99, CompanyId = 25, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 100, CompanyId = 26, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 101, CompanyId = 26, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 102, CompanyId = 26, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 103, CompanyId = 26, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 104, CompanyId = 27, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 105, CompanyId = 27, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 106, CompanyId = 27, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 107, CompanyId = 27, type = "Owner", Password = "Owner" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 108, CompanyId = 28, type = "chat employee", Password = "chat employee" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 109, CompanyId = 28, type = "Publishing Officer", Password = "Publishing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 110, CompanyId = 28, type = "Editing Officer", Password = "Editing Officer" });
            modelBuilder.Entity<CompanyType>().HasData(new CompanyType { Id = 111, CompanyId = 28, type = "Owner", Password = "Owner" });
















        }
    }

        }
