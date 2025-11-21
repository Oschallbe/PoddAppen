using PoddApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public interface IPodcastRepo
    {
        Task<List<Podcast>> GetAllAsync();
        Task AddAsync(Podcast podcast);
        Task<Podcast?> GetByRssUrlAsync(string rssUrl);
        Task UpdateAsync(Podcast podcast);
        Task DeleteAsync(string id);

        // Categories
        Task AddCategoryAsync(string categoryName);
        Task<List<Category>> GetAllCategoriesAsync();
        Task AddCategoryToPodcastAsync(string podcastId, string categoryId);
        Task RemoveCategoryFromPodcastAsync(string podcastId, string categoryId);
    }
}
