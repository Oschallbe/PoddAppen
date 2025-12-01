using MongoDB.Driver;
using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class PodcastRepository : IPodcastRepo
    {
        
        private readonly IMongoClient _client;
        private readonly IMongoCollection<Podcast> _collection;
        private readonly IMongoCollection<Category> _categoriesCollection;

        public PodcastRepository(string connectionString, string databaseName)
        {
            
            _client = new MongoClient(connectionString);
            var database = _client.GetDatabase(databaseName);
            _collection = database.GetCollection<Podcast>("Podcasts");
            _categoriesCollection = database.GetCollection<Category>("Category");
        }


        public async Task<List<Podcast>> GetAllAsync()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public async Task<Podcast?> GetByRssUrlAsync(string rssUrl)
        {
            return await _collection
                .Find(p => p.RssUrl == rssUrl)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await _categoriesCollection.Find(_ => true).ToListAsync();
        }


        public async Task AddAsync(Podcast podcast)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction(); 
                try
                {
                    await _collection.InsertOneAsync(session, podcast);
                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task UpdateAsync(Podcast podcast)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    await _collection.ReplaceOneAsync(session, p => p.Id == podcast.Id, podcast);
                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task DeleteAsync(string id)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    await _collection.DeleteOneAsync(session, p => p.Id == id);
                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task AddCategoryAsync(string categoryName)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    var category = new Category { Name = categoryName };
                    await _categoriesCollection.InsertOneAsync(session, category);
                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task AddCategoryToPodcastAsync(string podcastId, string categoryId)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);
                    var categoryObj = new Category
                    {
                        Id = categoryId
                    };
                    var update = Builders<Podcast>.Update.AddToSet(p => p.Categories, categoryObj);

                    await _collection.UpdateOneAsync(session, filter, update);
                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task RemoveCategoryFromPodcastAsync(string podcastId, string categoryId)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);
                    var categoryObj = new Category
                    {
                        Id = categoryId
                    };
                    var update = Builders<Podcast>.Update.Pull(p => p.Categories, categoryObj);

                    await _collection.UpdateOneAsync(session, filter, update);
                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }


        public async Task ChangeNamePodcastAsync(string podcastId, string newName)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);
                    var update = Builders<Podcast>.Update.Set(p => p.Name, newName);

                    await _collection.UpdateOneAsync(session, filter, update);
                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task DeleteCategoryAsync(string categoryId)
        {
            
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    
                    var podcastFilter = Builders<Podcast>.Filter.ElemMatch(p => p.Categories, c => c.Id == categoryId);
                    
                    var update = Builders<Podcast>.Update.PullFilter(p => p.Categories, c => c.Id == categoryId);

                    
                    await _collection.UpdateManyAsync(session, podcastFilter, update);

                    
                    await _categoriesCollection.DeleteOneAsync(session, c => c.Id == categoryId);

                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task ChangeCategoryNameAsync(string categoryId, string newName)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    var filter = Builders<Category>.Filter.Eq(c => c.Id, categoryId);
                    var update = Builders<Category>.Update.Set(c => c.Name, newName);

                    await _categoriesCollection.UpdateOneAsync(session, filter, update);

                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task<Podcast?> GetByIdAsync(string id)
        {
            return await _collection
                .Find(p => p.Id == id)
                .FirstOrDefaultAsync();
        }

    }
}