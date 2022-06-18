using MarfulApi.Model;

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
    }
}
