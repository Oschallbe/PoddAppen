using PoddApp.Models;

public interface IPoddService
{
    Task SetPodcastImageAsync(Podcast podcast);
    Task SetPodcastTitleAsync(Podcast podcast);
    Task SetPodcastDescriptionAsync(Podcast podcast);

    Task<List<Episode>> GetEpisodesAsync(Podcast podcast);

    Task SavePodcastAsync(Podcast podcast);
    Task<List<Podcast>> GetAllPodcastsAsync();
    Task DeletePodcastAsync(string id);
    Task ChangeNamePodcastAsync(string podcastId, string newName);


    //Categories
    Task AddCategoryAsync(string name);
    Task<List<Category>> GetAllCategoriesAsync();
    Task AddCategoryToPodcastAsync(string podcastId, string categoryId);
    Task RemoveCategoryFromPodcastAsync(string podcastId, string categoryId);
    Task ChangeCategoryPodcastAsync(string podcastId, string oldCategoryId, string newCategoryId);

    Task ChangeCategoryNameAsync(string categoryId, string newName);
}