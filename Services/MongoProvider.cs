using MongoDB.Driver;

namespace SampleUserApi.Services
{
    public abstract class MongoProvider<T> : IMongoProvider<T>
    {
        public IMongoDatabase database { get; set; }

        public IMongoCollection<T> List => database.GetCollection<T>(collectionName);

        public string collectionName { get; set; }
        protected MongoProvider(string collectionName){
            string connectionString = "mongodb://Pawskal:drjynfrnt1990@ds111608.mlab.com:11608/sample_user_api";
            var connection = new MongoUrlBuilder(connectionString);
            MongoClient client = new MongoClient(connectionString);
            database = client.GetDatabase(connection.DatabaseName);
            this.collectionName = collectionName;
        }
    }
}