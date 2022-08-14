using MarfulApi.Model;
namespace MarfulApi.Infrastructure
{
    public interface IInfulonserFollowInfulonser
    {
        public InfulonserFollowInfulonser GetInfulonserFollowInfulonser(int idFollow);
        public IQueryable<InfulonserFollowInfulonser> GetInfulonserFollowInfulonsers { get; }
        public void Save(InfulonserFollowInfulonser infulonserFollowInfulonser);
        public void Delete(int id);
        public void Update(InfulonserFollowInfulonser infulonserFollowInfulonser);
    }
}
