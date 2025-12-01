using PoddApp.BL;
using PoddApp.DAL;
using PoddApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class PoddService : IPoddService
{
    private readonly IRssReader rss;
    private readonly IPodcastRepo podcastRepo;

    public PoddService(IRssReader rssReader, IPodcastRepo podcastRepo)
    {
        rss = rssReader;
        this.podcastRepo = podcastRepo;
    }

    public async Task SetPodcastImageAsync(Podcast podcast)
    {
        podcast.ImageUrl = await rss.GetPodcastImageUrl(podcast.RssUrl);
    }

    public async Task SetPodcastTitleAsync(Podcast podcast)
    {
        podcast.Name = await rss.GetPodcastTitle(podcast.RssUrl);
    }

    public async Task SetPodcastDescriptionAsync(Podcast podcast)
    {
        podcast.Description = await rss.GetPodcastDescription(podcast.RssUrl);
    }

    public async Task<List<Episode>> GetEpisodesAsync(Podcast podcast)
    {
        var podFromDb = await podcastRepo.GetByIdAsync(podcast.Id);

        if (podFromDb != null && podFromDb.Episodes.Any())
            return podFromDb.Episodes;

        var episodes = await rss.GetRSSPod(podcast.RssUrl);

        podcast.Episodes = episodes;
        await podcastRepo.UpdateAsync(podcast);

        return episodes;
    }


    public async Task SavePodcastAsync(Podcast podcast)
    {
        await podcastRepo.AddAsync(podcast);
    }

    public async Task<List<Podcast>> GetAllPodcastsAsync()
    {
        return await podcastRepo.GetAllAsync();
    }

    public async Task DeletePodcastAsync(string id)
    {
        await podcastRepo.DeleteAsync(id);
    }
    public async Task AddCategoryAsync(string name)
    {
        await podcastRepo.AddCategoryAsync(name);
    }

    public async Task<List<Category>> GetAllCategoriesAsync()
    {
        return await podcastRepo.GetAllCategoriesAsync();
    }

    public async Task AddCategoryToPodcastAsync(string podcastId, string categoryId)
    {
        await podcastRepo.AddCategoryToPodcastAsync(podcastId, categoryId);
    }

    public async Task RemoveCategoryFromPodcastAsync(string podcastId, string categoryId)
    {
        await podcastRepo.RemoveCategoryFromPodcastAsync(podcastId, categoryId);
    }

    public async Task ChangeNamePodcastAsync(string podcastId, string newName)
    {
        await podcastRepo.ChangeNamePodcastAsync(podcastId, newName);
    }

    public async Task ChangeCategoryNameAsync(string categoryId, string newName)
    {
        await podcastRepo.ChangeCategoryNameAsync(categoryId, newName);
    }

    public async Task ChangeCategoryPodcastAsync(Podcast podcast, List<Category> newCategories)
    {
        podcast.Categories = newCategories;
        await podcastRepo.UpdateAsync(podcast);
    }

    public async Task DeleteCategoryAsync(string categoryId)
    {
        await podcastRepo.DeleteCategoryAsync(categoryId);
    }

}
