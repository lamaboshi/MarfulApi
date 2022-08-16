using MarfulApi.Model;
using MarfulApi.Dto;
using MarfulApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
namespace MarfulApi.Data
{
    public class SearchRepo : ISearch
    {
        public readonly MarfulDbContext _db;
        public SearchRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public List<SearchDto> Search(string search)
        {
            List<SearchDto> data = new List<SearchDto>();
            List<object> inf = _db.Infulonsers.Where(p => p.Name.Contains(search)).ToList<object>();
            List<object> cmp = _db.Companies.Where(p => p.Name.Contains(search)).ToList<object>();
            List<object> brand = _db.Brands.Where(p => p.Name.Contains(search)).Include(r => r.Infulonser).Include(r => r.CompanyContent).ToList<object>();
            List<object> product = _db.Products.Where(p => p.Name.Contains(search)).Include(r => r.Brand).ToList<object>();
            List<object> content = _db.Contents.Where(p => p.Name.Contains(search)).Include(r => r.CompanyContent).Include(r => r.InfulonserContent).ToList<object>();
            if (inf.Count != 0)
            {
                SearchDto dto = new SearchDto();
                dto.search = inf;
                dto.Type = "infulonser";
                data.Add(dto);

            }
            if (cmp.Count != 0)
            {
                SearchDto dto = new SearchDto();
                dto.search = cmp;
                dto.Type = "company";
                data.Add(dto);
            }
            if (brand.Count != 0)
            {
                SearchDto dto = new SearchDto();
                dto.search = brand;
                dto.Type = "brand";
                data.Add(dto);

            }
            if (product.Count != 0)
            {
                SearchDto dto = new SearchDto();
                dto.search = product;
                dto.Type = "product";
                data.Add(dto);
            }
            if (content.Count != 0)
            {
                //foreach (Content e in content)
                //{
                //    SearchDto dto = new SearchDto();
                //    var infContent = _db.InfulonserContents.Where(p => p.ContentId == e.Id).Include(r => r.Infulonser).ToList<object>();
                //    if (infContent != null)
                //    {
                //        dto.search = infContent;
                //        dto.Type = "infulonser";
                //        data.Add(dto);
                //    }
                //    var cmpContent = _db.CompanyContents.Where(p => p.ContentId == e.Id).Include(r => r.Company).ToList<object>();
                //    if (cmpContent != null)
                //    {
                //        dto.search = cmpContent;
                //        dto.Type = "company";
                //        data.Add(dto);
                //    }
                //}
                SearchDto dto = new SearchDto();
                dto.search = content;
                dto.Type = "content";
                data.Add(dto);
            }
            if (data.Count != 0) return data;
            return null;
        }
        public SearchDto SearchInfulonser(string search)
        {
            List<object> inf = _db.Infulonsers.Where(p => p.Name.Contains(search) ).ToList<object>();
            SearchDto dto = new SearchDto();
            if (inf.Count != 0)
            {
                dto.search = inf;
                dto.Type = "infulonser";
                return dto;
            }
            return null;
        }
        public SearchDto SearchCompany(string search)
        {
            List<object> cmp = _db.Companies.Where(p => p.Name.Contains(search)).ToList<object>();
            SearchDto dto = new SearchDto();
            if (cmp.Count != 0)
            {
                dto.search = cmp;
                dto.Type = "company";
                return dto;
            }
            return null;
        }
        public SearchDto SearchBrand(string search)
        {
            var brand = _db.Brands.Where(p => p.Name.Contains(search)).Include(r => r.Infulonser).Include(r => r.CompanyContent).ToList<object>();
            SearchDto dto = new SearchDto();
            if (brand.Count != 0)
            {
                dto.search = brand;
                dto.Type = "brand";
                return dto;
            }
            return null;
        }
        public SearchDto SearchProduct(string search)
        {
            List<object> product = _db.Products.Where(p => p.Name.Contains(search)).Include(r => r.Brand).ToList<object>();
            SearchDto dto = new SearchDto();
            if (product.Count != 0)
            {
                dto.search = product;
                dto.Type = "product";
                return dto;
            }
            return null;
        }
        public SearchDto SearchContent(string search)
        {
            List<object> content = _db.Contents.Where(p => p.Name.Contains(search)).Include(r => r.CompanyContent).Include(r => r.InfulonserContent).ToList<object>();
            SearchDto dto = new SearchDto();
            if (content.Count != 0)
            {
                dto.search = content;
                dto.Type = "content";
                return dto;
            }
            return null;
        }
        public List<SearchDto> SearchSelectedContent(int Id, string search)
        {
             List<object> Accounts = new List<object>();
            List<SearchDto> dto = new List<SearchDto>();
            Content content = _db.Contents.FirstOrDefault(p => p.Id == Id);
            if (content != null)
            {

                var infContent = _db.InfulonserContents.Where(p => p.ContentId == content.Id).Include(r => r.Infulonser).ToList<object>();
                if (infContent.Count != 0)
                {
                    SearchDto Searchinf = new SearchDto();
                    Searchinf.Type = "infulonser";
                    Searchinf.search = infContent;
                    dto.Add(Searchinf);
                }
                var cmpContent = _db.CompanyContents.Where(p => p.ContentId == content.Id).Include(r => r.Company).ToList<object>();
                if (cmpContent.Count != 0)
                {
                    SearchDto Searchcmp = new SearchDto();
                    Searchcmp.Type = "company";
                    Searchcmp.search = cmpContent;
                    dto.Add(Searchcmp);
                }
                if (dto.Count != 0) return dto;
                else return null;
            }
                
            else return null;
        }
    }
}
