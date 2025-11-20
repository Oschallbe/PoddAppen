using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PoddApp.Models
{
    public class Podcast
    {
        [BsonId]
        public int Id { get; set; }         // MongoDB ObjectId som string

        [BsonElement("Name")]
        public string Name { get; set; }       // Namn på podden

        [BsonElement("RssUrl")]
        public string RssUrl { get; set; }     // URL till RSS-flödet

        [BsonElement("Category")]
        public List<Category> Categorys { get; set; }   // Kategori (t.ex. "Teknik")

        [BsonElement("ImageUrl")]
        public string ImageUrl { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        [BsonElement("Episodes")]
        public List<Episode> Episodes { get; set; } = new(); // Lista av avsnitt

    }
}
