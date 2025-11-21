using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PoddApp.Models;

public class Podcast
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Name { get; set; }
    public string RssUrl { get; set; }

    // 🔥 Flera kategorier → LISTA MED STRINGS (ObjectId)
    public List<string> CategoryIds { get; set; } = new();

    public string ImageUrl { get; set; }
    public string Description { get; set; }

    public List<Episode> Episodes { get; set; } = new();
}
