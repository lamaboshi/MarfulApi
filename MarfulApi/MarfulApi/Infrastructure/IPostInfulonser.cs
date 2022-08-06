using MarfulApi.Model;
namespace MarfulApi.Infrastructure
{
    public interface IPostInfulonser
    {
        public PostInfulonser GetPostInfulonser(int id);
        public IQueryable<PostInfulonser> GetPostInfulonsers { get; }
        public double[] Save(PostInfulonser postInfulonser);
        public List<PostInfulonser> GetUserPostByInfu(int IdInfu);
        public void Delete(int id);
        public void Update(PostInfulonser postInfulonser);
    }
}
