using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IMessage
    {
        public IQueryable<Message> GetAllMessages { get;  }
        public void SaveMessage(Message message);
    }
}
