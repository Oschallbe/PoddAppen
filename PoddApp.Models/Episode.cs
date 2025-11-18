using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PoddApp.Models
{
    public class Episode
    {
        public string Id { get; set; }         // MongoDB ObjectId som string
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Link { get; set; }
    }
}
