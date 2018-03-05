using System.Collections.Generic;
using System.Threading.Tasks;
using SampleUserApi.Models;
using System;

namespace SampleUserApi.Services
{
    public class UserService
    {
        IUserProvider provider;
        public UserService(IUserProvider provider) {
            this.provider = provider;
        }

        public async Task<List<User>> GetList() =>
            await provider.GetList();

        public async Task<User> Find(string id) => 
            await provider.Find(id);

        public Task Create(User T)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(User T)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}