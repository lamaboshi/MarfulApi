using MarfulApi.Data;
using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.SignalR;

namespace MarfulApi.Hubs
{
    public partial class ManagementHub :Hub

    {
        /// <summary>
        /// Pings this instance.
        /// </summary>
            private readonly IConversation _repoConversation;
        private readonly IMessage _repoMessage;
        public ManagementHub(IConversation repoConversation, IMessage repoMessage)
        {
            _repoConversation = repoConversation;
            _repoMessage = repoMessage;
        }
        public async Task Ping()
        {
            await Return("pong", new object[] { $"{DateTime.Now} : Pong" });
        }

        /// <summary>
        /// Helloes this instance.
        /// </summary>
        /// <returns></returns>
        public Task<string> Hello()
        {
            return Task.FromResult($"World at {DateTime.Now}");
        }

        public Task<List<Conversation>> GA_Conversations()
        {
            var data = _repoConversation.GetConversations();
            return Task.FromResult(data);

        }
        public Task<List<Message>> GA_Messages(int IdConvo)
        {
            var data = _repoMessage.GetMessagesChat(IdConvo);
            return Task.FromResult(data);

        }
        public async Task SendMessage(string text, int idConv, bool iscCompa)
        {
            
           var res= _repoMessage.SaveMessage(new Message{Id=0,Text=text,ConversationId=idConv,MessageStatus=iscCompa,SendTime=DateTime.Now });
           await Clients.All.SendAsync("SendMessage", res);
        }


        private async Task Return(string method, object[] args)
        {
            await Clients.All.SendAsync(method, args);
        }
    }
}
