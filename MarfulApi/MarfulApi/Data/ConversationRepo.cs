using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class ConversationRepo : IConversation
    {
        private readonly MarfulDbContext _db;
        public ConversationRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public IQueryable<Conversation> GetConversations => _db.Conversations;

        public void Delete(int id)
        {
            var result = _db.Conversations.First(p => p.Id == id);
            if (result != null)
            {
                _db.Conversations.Remove(result);
                _db.SaveChanges();
            }
        }

        public Conversation GetConversation(int IdConversation)
        {
            var result = _db.Conversations.First(p => p.Id == IdConversation);
            if (result != null) return result;
            else throw new NotImplementedException();
        }

        public void Save(Conversation conversation)
        {
            if (conversation.Id == 0)
            {
                _db.Conversations.Add(conversation);
                _db.SaveChanges();
            }
        }

        public void Update(Conversation conversation)
        {
            if (conversation.Id != 0)
            {
                var conversationEntity = _db.Conversations.First(t => t.Id == conversation.Id);
                if (conversationEntity != null)
                {
                    conversationEntity.InfulonserId = conversation.InfulonserId;
                    conversationEntity.Start = conversation.Start;
                    conversation.CompanyId = conversation.CompanyId;
                    _db.SaveChanges();
                }
            }
        }
    }
}
