namespace PoddApp.Models
{
    public class Podcast
    {
        public string Id { get; set; }         // MongoDB ObjectId som string
        public string Name { get; set; }       // Namn på podden
        public string RssUrl { get; set; }     // URL till RSS-flödet
        public string Category { get; set; }   // Kategori (t.ex. "Teknik")
        public List<Episode> Episodes { get; set; } = new(); // Lista av avsnitt
    }
}
