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

        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(p => p.Id == id);
        }

        public async Task AddAsync(Podcast podcast)
        {
            await _collection.InsertOneAsync(podcast);
        }

        public async Task<Podcast?> GetByRssUrlAsync(string rssUrl)
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

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _categoriesCollection.Find(_ => true).ToListAsync();
        }

        public Task AddCategoryToPodcastAsync(string podcastId, string categoryId)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);
            var categoryObj = new Category
            {
                Id = categoryId
            };
            var update = Builders<Podcast>.Update.AddToSet(p => p.Categories, categoryObj);
            return _collection.UpdateOneAsync(filter, update);
        }

        public Task RemoveCategoryFromPodcastAsync(string podcastId, string categoryId)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);
            var categoryObj = new Category
            {
                Id = categoryId
            };
            var update = Builders<Podcast>.Update.Pull(p => p.Categories, categoryObj);
            return _collection.UpdateOneAsync(filter, update);
        }

        public Task DeleteEpisodeAsync(string podcastId, string episodeId)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);

            var update = Builders<Podcast>.Update.PullFilter(
                p => p.Episodes,
                e => e.Id == episodeId
                );

            return _collection.UpdateOneAsync(filter, update);
        }

        public Task ChangeNamePodcastAsync(string podcastId, string newName)
        {
            var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);
            var update = Builders<Podcast>.Update.Set(p => p.Name, newName);
            return _collection.UpdateOneAsync(filter, update);
        }
    }
}