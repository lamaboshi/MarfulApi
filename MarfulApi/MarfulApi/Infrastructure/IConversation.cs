using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IConversation
    {
        public void Update(Conversation conversation);
        public void Save(Conversation conversation);
        public List<Conversation> GetConversations();
        public void Delete(int id);
        public Conversation GetConversation(int IdConversation);
    }
}
