using MarfulApi.Model;
using Microsoft.AspNetCore.SignalR;

namespace MarfulApi.Hubs
{
    public class ManagementHub :Hub
    {
        /// <summary>
        /// Pings this instance.
        /// </summary>
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
        public async Task SendMessage(string user, Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        private async Task Return(string method, object response)
        {
            await Return(method, new[] { response });
        }

        private async Task Return(string method, object[] args)
        {
            await Clients.Caller.SendCoreAsync(method, args);
        }
    }
}
