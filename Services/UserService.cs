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

        public async Task<List<User>> GetList()
        {
            Console.WriteLine("in service");
            var list = await provider.GetList();
            Console.WriteLine("out service");
            return list;
        }

        public Task<User> Find(string id)
        {
            throw new System.NotImplementedException();
        }

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