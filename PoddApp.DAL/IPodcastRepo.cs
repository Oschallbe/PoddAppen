

using PoddApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public interface IPodcastRepo
    {
        Task<Podcast?> GetByIdAsync(string id);

        Task<List<Podcast>> GetAllAsync();
        Task AddAsync(Podcast podcast);
        Task<Podcast?> GetByRssUrlAsync(string rssUrl);
        Task UpdateAsync(Podcast podcast);
        Task DeleteAsync(string id);
        Task ChangeNamePodcastAsync(string podcastId, string newName);

        //Categories
        Task AddCategoryAsync(string categoryName);
        Task<List<Category>> GetAllCategoriesAsync();
        Task AddCategoryToPodcastAsync(string podcastId, string categoryId);
        Task RemoveCategoryFromPodcastAsync(string podcastId, string categoryId);
        Task ChangeCategoryNameAsync(string categoryId, string newName);
        Task DeleteCategoryAsync(string categoryId);
    }
}