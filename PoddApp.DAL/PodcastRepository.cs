using MongoDB.Driver;
using PoddApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class PodcastRepository: IPodcastRepo
    {
        private readonly IMongoCollection<Podcast> _collection;

        public PodcastRepository(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _collection = database.GetCollection<Podcast>("Podcasts");
        }

        public async Task UpdateAsync(Podcast podcast)
        {
            await _collection.ReplaceOneAsync(p => p.Id == podcast.Id, podcast);
        }

        public async Task<List<Podcast>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(p => p.Id == id);
        }

        public async Task AddAsync(Podcast podcast)
        {
            await _collection.InsertOneAsync(podcast);
        }

        public async Task<Podcast?> GetByRssUrlAsync(String rssUrl)
        {
            return await _collection
                .Find(p => p.RssUrl == rssUrl)
                .FirstOrDefaultAsync();
        }
    }
}
