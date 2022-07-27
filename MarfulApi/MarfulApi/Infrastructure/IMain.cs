using MarfulApi.Model;
using MarfulApi.Dto;
namespace MarfulApi.Infrastructure
{
    public interface IMain
    {
        public List<PostDto> GetUserPost(string email);
        public List<PostDto> GetUserPostByConent(int IdContent, string email);
        public List<PostDto> GetInfulonserPost(string email);
        public List<PostDto> GetInfulonserPostByConent(int IdContent, string email);
        public List<Post> GetCompanyPost( string email);
        public List<Post> GetCompanyPostByConent(int IdContent, string email);
        public double GetLikesCount(int id, string Type);

        public double GetDisLikesCount(int id, string Type);
    }
}
