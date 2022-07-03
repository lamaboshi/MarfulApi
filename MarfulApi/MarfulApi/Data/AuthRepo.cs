using MarfulApi.Dto;
using MarfulApi.Infrastructure;

namespace MarfulApi.Data
{
    public class AuthRepo : IAuth
    {
        private readonly MarfulDbContext _db;
        public AuthRepo(MarfulDbContext db)
        {
            _db = db;
        }
        public object? GetAuth(string email, string password)
        {
            var data = _db.Users.Where(t => t.Email == email&&t.Password==password).FirstOrDefault();
            if (data != null) return new AuthDto {Data=data,Type= "user" } ;
            var dataComapny = _db.Companies.Where(t => t.Email == email && t.Password == password).FirstOrDefault();
            if (dataComapny != null) return new AuthDto { Data = dataComapny, Type = "comapny" };
            var dataiInful = _db.Infulonsers.Where(t => t.Email == email && t.Password == password).FirstOrDefault();
            if (dataiInful != null) return new AuthDto { Data = dataiInful, Type = "infulonser" };
            return null;
        }
        public object? GetEmail(string email)
        {
            var dataUser = _db.Users.Where(p => p.Email == email).FirstOrDefault();
            if (dataUser != null)
            {
                return new IsExistingDto { Id = dataUser.Id, Type = "user" };
            }
            var dataCompany = _db.Companies.Where(p => p.Email == email).FirstOrDefault();
            if (dataCompany != null)
            {
                return new IsExistingDto { Id = dataCompany.Id, Type = "company" };
            }
            var dataInfulonser = _db.Infulonsers.Where(p => p.Email == email).FirstOrDefault();
            if (dataInfulonser != null)
            {
                return new IsExistingDto {  Id= dataInfulonser.Id, Type = "infulonser" };
            }
            return null;
        }
    }
}
