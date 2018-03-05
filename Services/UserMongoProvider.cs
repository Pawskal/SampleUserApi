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
            // this.List.InsertOne(fakeUserService.fakeUser.Generate());
        }

        public async Task<User> Find(string id) =>
            await this.List.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();

        public async Task<List<User>> GetList() => 
            await this.List.Find(new FilterDefinitionBuilder<User>().Empty).ToListAsync();

        public Task Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task Update(User T)
        {
            throw new NotImplementedException();
        }
    }
}