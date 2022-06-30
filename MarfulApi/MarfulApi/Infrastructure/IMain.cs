using MarfulApi.Model;
using MarfulApi.Dto;
namespace MarfulApi.Infrastructure
{
    public interface IMain
    {
        public List<PostDto> GetPost(string email);
        public List<PostDto> GetPostByConent(int IdContent, string email);
    }
}
