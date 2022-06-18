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
            private readonly IConversation _repo;
        public ManagementHub(IConversation repo)
        {
            _repo = repo;
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

        //public async Task<List<Conversation>> GA_Conversations()
        //{
        //    var data= _repo.GetConversations.ToList();
        //    return data;

        //}
        public async Task SendMessage(string user, Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        private async Task Return(string method, object[] args)
        {
            await Clients.All.SendAsync(method, args);
        }
    }
}
