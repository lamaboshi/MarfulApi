﻿using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.EntityFrameworkCore;

namespace MarfulApi.Data
{
    public class UserCompanyRepo : IUserCompany
    {
        private readonly MarfulDbContext _db;
        public UserCompanyRepo(MarfulDbContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            var result = _db.UserCompanies.FirstOrDefault(p => p.Id == id);
            if (result != null)
            {
                _db.UserCompanies.Remove(result);
                _db.SaveChanges();
            }
        }

        public List<Company> GetAllUserCompanys(int userId)
        {
            var data = _db.UserCompanies.Where(p => p.UserId == userId).Include(z => z.Company).Select(o=>o.Company).ToList();
            return data;
        }

        public UserCompany GetUserCompany(int id)
        {
            var result = _db.UserCompanies.First(p => p.Id == id);
            if (result != null) return result;
            else return null;
        }

        public void Save(UserCompany userCompany)
        {
            if (userCompany.Id == 0)
            {
                _db.UserCompanies.Add(userCompany);
                _db.SaveChanges();
            }
        }

    }
}
