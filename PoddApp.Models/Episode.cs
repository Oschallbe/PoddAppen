using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PoddApp.Models
{
    public class Episode
    {
        public string Id { get; set; }         // MongoDB ObjectId som string

        [BsonElement("Title")]
        public string Title { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("PublishedDate")]
        public DateTime PublishedDate { get; set; }

        [BsonElement("Link")]
        public string Link { get; set; }
    }
}
