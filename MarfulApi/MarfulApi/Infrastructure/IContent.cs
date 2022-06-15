using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IContent
    {
        public void Update(Content content);
        Content GetContent(int id);
        IQueryable<Content> GetContents { get; }
        void Save(Content content);
        void Delete(int id);
    }
}
