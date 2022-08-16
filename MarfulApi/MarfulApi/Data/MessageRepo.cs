using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class MessageRepo : IMessage
    {
        private readonly MarfulDbContext _db;
        public MessageRepo(MarfulDbContext db)
        {
            _db = db;
        }

        public IQueryable<Message> GetMessages => _db.Messages;

        public Message GetMessage(int IdMessage)
        {
            var result = _db.Messages.First(p => p.Id == IdMessage);
            if (result != null) return result;
            else return null;
        }

        public List<Message> GetMessagesChat(int IdConver)
        {
            var result = _db.Messages.Where(e => e.ConversationId == IdConver).ToList();
            if (result != null) return result;
            else return null;
        }

        public Message SaveMessage(Message message)
        {
            if (message.Id == 0)
            {
                _db.Messages.Add(message);
                _db.SaveChanges();
                return message;
            }
            return null;
        }
    }
}
