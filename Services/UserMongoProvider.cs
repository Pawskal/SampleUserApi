using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SampleUserApi.Models;

namespace SampleUserApi.Services
{
    public class UserMongoProvider : MongoProvider<User>, IUserProvider
    {

        public UserMongoProvider(FakeUserService fakeUserService) : base("users"){

            this.List.InsertOne(fakeUserService.fakeUser.Generate());
        }

        public Task Create(User T)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<User> Find(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetList()
        {
            Console.WriteLine("in provide");

            return await this.List.Find(new FilterDefinitionBuilder<User>().Empty).ToListAsync();
        }

        public Task Update(User T)
        {
            throw new NotImplementedException();
        }
    }
}