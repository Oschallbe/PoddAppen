using MongoDB.Driver;
using PoddApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class PodcastRepository : IPodcastRepo
    {
        private readonly IMongoCollection<Podcast> _collection;
        private readonly IMongoCollection<Category> _categoriesCollection;
        public PodcastRepository(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _collection = database.GetCollection<Podcast>("Podcasts");
            _categoriesCollection = database.GetCollection<Category>("Category");
        }

        public async Task UpdateAsync(Podcast podcast)
        {
            await _collection.ReplaceOneAsync(p => p.Id == podcast.Id, podcast);
        }

        public async Task<List<Podcast>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task DeleteAsync(int id)
        {
            await _collection.DeleteOneAsync(p => p.Id == id);
        }

        public async Task AddAsync(Podcast podcast)
        {
            var maxId = await _collection.Find(_ => true)
                        .SortByDescending(p => p.Id)
                        .Limit(1)
                        .FirstOrDefaultAsync();

            int nextId = maxId?.Id + 1 ?? 0;

            podcast.Id = nextId;

            await _collection.InsertOneAsync(podcast);
        }

        public async Task<Podcast?> GetByRssUrlAsync(String rssUrl)
        {
            return await _collection
                .Find(p => p.RssUrl == rssUrl)
                .FirstOrDefaultAsync();
        }

        public async Task AddCategoryAsync(string categoryName)
        {
            var category = new Category { Name = categoryName };
            await _categoriesCollection.InsertOneAsync(category);
        }
    }
}
