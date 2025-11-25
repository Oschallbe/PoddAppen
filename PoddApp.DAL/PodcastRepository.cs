using MongoDB.Driver;
using PoddApp.Models;
using System; // Lagt till för String i DeleteEpisodeAsync och Exception
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public class PodcastRepository : IPodcastRepo
    {
        // NYTT: Lagra klienten för att kunna skapa sessioner och transaktioner
        private readonly IMongoClient _client;
        private readonly IMongoCollection<Podcast> _collection;
        private readonly IMongoCollection<Category> _categoriesCollection;

        public PodcastRepository(string connectionString, string databaseName)
        {
            // NYTT: Klienten sparas nu i fältet _client
            _client = new MongoClient(connectionString);
            var database = _client.GetDatabase(databaseName);
            _collection = database.GetCollection<Podcast>("Podcasts");
            _categoriesCollection = database.GetCollection<Category>("Category");
        }

        // --- READ OPERATIONS (Ingen transaktion krävs) ---

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

        // --- WRITE OPERATIONS (Transaktioner krävs) ---

        public async Task AddAsync(Podcast podcast)
        {
            using (var session = await _client.StartSessionAsync()) // 1. Starta session
            {
                session.StartTransaction(); // 2. Starta transaktion
                try
                {
                    await _collection.InsertOneAsync(session, podcast); // Använd session
                    await session.CommitTransactionAsync(); // 3. Commit vid framgång
                }
                catch
                {
                    await session.AbortTransactionAsync(); // 4. Avbryt vid fel
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
                    await _collection.ReplaceOneAsync(session, p => p.Id == podcast.Id, podcast); // Använd session
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
                    await _collection.DeleteOneAsync(session, p => p.Id == id); // Använd session
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
                    await _categoriesCollection.InsertOneAsync(session, category); // Använd session
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

                    await _collection.UpdateOneAsync(session, filter, update); // Använd session
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

                    await _collection.UpdateOneAsync(session, filter, update); // Använd session
                    await session.CommitTransactionAsync();
                }
                catch
                {
                    await session.AbortTransactionAsync();
                    throw;
                }
            }
        }

        public async Task DeleteEpisodeAsync(string podcastId, string episodeId)
        {
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    var filter = Builders<Podcast>.Filter.Eq(p => p.Id, podcastId);

                    var update = Builders<Podcast>.Update.PullFilter(
                        p => p.Episodes,
                        e => e.Id == episodeId
                        );

                    await _collection.UpdateOneAsync(session, filter, update); // Använd session
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

                    await _collection.UpdateOneAsync(session, filter, update); // Använd session
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
            // OBS! _client måste vara satt i konstruktorn för att transaktioner ska fungera.
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    // 1. Ta bort referensen till kategorin från ALLA Podcasts som använder den
                    var podcastFilter = Builders<Podcast>.Filter.ElemMatch(p => p.Categories, c => c.Id == categoryId);
                    // Använder $pullFilter för att ta bort elementet från arrayen
                    var update = Builders<Podcast>.Update.PullFilter(p => p.Categories, c => c.Id == categoryId);

                    // Använd UpdateManyAsync för att applicera ändringen på alla poddar
                    await _collection.UpdateManyAsync(session, podcastFilter, update);

                    // 2. Ta bort själva kategorin från kategorisamlingen
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
            // Måste uppdatera interfacet IPodcastRepo med denna signatur först
            using (var session = await _client.StartSessionAsync())
            {
                session.StartTransaction();
                try
                {
                    var filter = Builders<Category>.Filter.Eq(c => c.Id, categoryId);
                    var update = Builders<Category>.Update.Set(c => c.Name, newName);

                    // Uppdatera kategorinamnet i kategorisamlingen
                    await _categoriesCollection.UpdateOneAsync(session, filter, update);

                    // Notera: Om Podcast-modellen lagrar kategorinamnet (istället för bara ID),
                    // skulle en andra uppdatering mot Podcast-samlingen behövas här.

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