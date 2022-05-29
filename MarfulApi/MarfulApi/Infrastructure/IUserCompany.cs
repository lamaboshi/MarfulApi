using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IUserCompany
    {
        public UserCompany GetUserCompany(int id);
        public IQueryable<UserCompany> GetUserCompanys { get; }
        public void Save(UserCompany userCompany);
        public void Delete(int id);
    }
}
