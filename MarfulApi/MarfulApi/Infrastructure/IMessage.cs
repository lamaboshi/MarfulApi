using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IMessage
    {
        public void SaveMessage(Message message);
        public IQueryable<Message> GetMessages{ get; }
        public Message GetMessage(int IdMessage);
    }
}
