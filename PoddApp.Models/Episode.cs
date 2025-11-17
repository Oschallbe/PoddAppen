using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PoddApp.Models
{
    public class Episode
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
