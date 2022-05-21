using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IContent
    {
        public IQueryable<Content> GetContents { get; }
    }
}
