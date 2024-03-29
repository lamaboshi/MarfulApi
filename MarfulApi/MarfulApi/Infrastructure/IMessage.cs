﻿using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IMessage
    {
        public Message SaveMessage(Message message);
        public IQueryable<Message> GetMessages{ get; }
        public List<Message> GetMessagesChat(int IdConver);
        public Message GetMessage(int IdMessage);
    }
}
