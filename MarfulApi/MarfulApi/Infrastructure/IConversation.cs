using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IConversation
    {
        public void Update(Conversation conversation);
        public void Save(Conversation conversation);
        public IQueryable<Conversation> GetConversations { get; }
        public void Delete(int id);
        public Conversation GetConversation(int IdConversation);
    }
}
