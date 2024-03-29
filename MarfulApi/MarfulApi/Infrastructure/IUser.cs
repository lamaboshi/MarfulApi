﻿using MarfulApi.Model;
using MarfulApi.Dto;
namespace MarfulApi.Infrastructure
{
    public interface IUser
    {
        public User GetUser(int id);
        public IQueryable<User> GetUsers { get; }
        public void Save(User user);
        public void Update(User user);
        public void Delete(int id);
        public bool IsExisting(string email);
        public void ChangePassword(int Id, string password);
        public List<object> GetFollowed(string email);
        public double GetFollowedCount(string email);
       
    }
}
