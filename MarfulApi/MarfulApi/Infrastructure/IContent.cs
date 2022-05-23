using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IContent
    {
        Content GetContent(int id);
        IQueryable<Content> GetContents { get; }
        void Save(Content content);
        void Delete(int id);
    }
}
