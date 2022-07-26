using MarfulApi.Model;
namespace MarfulApi.Infrastructure
{
    public interface IPostInfulonser
    {
        public PostInfulonser GetPostInfulonser(int id);
        public IQueryable<PostInfulonser> GetPostInfulonsers { get; }
        public void Save(PostInfulonser postInfulonser);
        public void Delete(int id);
        public void Update(PostInfulonser postInfulonser);
    }
}
