using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Data
{
    public class MessageRepo : IMessage
    {
        public IQueryable<Message> GetAllMessages => throw new NotImplementedException();

        public void SaveMessage(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
