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

        public async Task<List<Podcast>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task AddAsync(Podcast podcast)
        {
            await _collection.InsertOneAsync(podcast);
        }
    }
}
