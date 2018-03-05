using MongoDB.Driver;

namespace SampleUserApi.Services
{
    public interface IMongoProvider<T>
    {
        string collectionName { get; set; }
        IMongoDatabase database { get; set; }
        
        IMongoCollection<T> List { get; }
    }
}