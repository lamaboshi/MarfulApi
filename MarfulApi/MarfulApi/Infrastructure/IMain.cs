using MarfulApi.Model;
using MarfulApi.Dto;
namespace MarfulApi.Infrastructure
{
    public interface IMain
    {
        public List<PostDto> GetUserPost(string email);
        public List<PostDto> GetUserPostByConent(int IdContent, string email);
      //  public List<PostDto> GetInfulonserPost(string email);
      //  public List<PostDto> GetIndulonserPostByConent(int IdContent, string email);
      //  public List<PostDto> GetCompanyPost( string email);
      //  public List<PostDto> GetCompanyPostByConent(int IdContent, string email);

    }
}
