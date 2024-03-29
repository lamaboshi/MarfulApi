﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarfulApi.Model;
using MarfulApi.Dto;

namespace MarfulApi.Infrastructure
{
    public interface IInfulonser
    {
       public Infulonser GetInfulonser(int id);
       public IQueryable<Infulonser> GetInfulonsers { get; }
        public List<Post> getAllPostInfulonser(int Id);
        public void Save(Infulonser infulonser);
       public void Delete(int id);
       public void Update(Infulonser infulonser);
        public bool IsExisting(string email);
        public List<Brand> GetInflBrand(int id);
        public void ChangePassword(int Id,string password);
        public double GetFollowersCount(string email);
        public List<object> GetFollowers(string email);

        public InfulonserWebDto GetInfulonserAll(string email);
    }
}
