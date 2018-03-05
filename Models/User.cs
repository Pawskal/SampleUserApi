using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SampleUserApi.Models
{
    public class User
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string ID {get; set;}
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}