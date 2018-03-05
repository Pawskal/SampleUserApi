using System;
using System.Collections.Generic;
using SampleUserApi.Models;

using Bogus;
using System.Threading.Tasks;

namespace SampleUserApi.Services
{
    public class UserLocalProvider : IUserProvider
    {
        public List<User> List { get; }
        
        public UserLocalProvider(FakeUserService fakeUserService){
            List = new List<User>();

            for (int i = 0; i < 10; i++) {
                List.Add(fakeUserService.fakeUser.Generate());
            }
        }

        public Task<List<User>> GetList()
        {
            throw new NotImplementedException();
        }

        public Task<User> Find(string id)
        {
            throw new NotImplementedException();
        }

        public Task Create(User T)
        {
            throw new NotImplementedException();
        }

        public Task Update(User T)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}