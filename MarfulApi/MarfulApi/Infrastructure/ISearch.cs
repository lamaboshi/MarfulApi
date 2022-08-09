using MarfulApi.Dto;
using MarfulApi.Model;
namespace MarfulApi.Infrastructure
{
    public interface ISearch
    {
        public List<SearchDto> Search(string search);
        public SearchDto SearchInfulonser(string search);
        public SearchDto SearchCompany(string search);
        public SearchDto SearchBrand(string search);
        public SearchDto SearchProduct(string search);
        public SearchDto SearchContent(string search);
        public List<SearchDto> SearchSelectedContent( int Id,string search );
    }
}
