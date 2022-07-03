using MarfulApi.Model;

namespace MarfulApi.Infrastructure
{
    public interface IUserCompany
    {
        public UserCompany GetUserCompany(int id);
        public List<Company> GetAllUserCompanys(int userId);
        public void Save(UserCompany userCompany);
        public void Delete(int id);
    }
}
