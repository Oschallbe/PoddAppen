using PoddApp.BL;
using PoddApp.DAL;
using PoddApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public class PoddService : IPoddService
{
    private readonly IRssReader _rss;
    private readonly IPodcastRepo _podcastRepo;

    public PoddService(IRssReader rssReader, IPodcastRepo podcastRepo)
    {
        _rss = rssReader;
        _podcastRepo = podcastRepo;
    }

    public async Task SetPodcastImageAsync(Podcast podcast)
    {
        podcast.ImageUrl = await _rss.GetPodcastImageUrl(podcast.RssUrl);
    }

    public async Task SetPodcastTitleAsync(Podcast podcast)
    {
        podcast.Name = await _rss.GetPodcastTitle(podcast.RssUrl);
    }

    public async Task SetPodcastDescriptionAsync(Podcast podcast)
    {
        podcast.Description = await _rss.GetPodcastDescription(podcast.RssUrl);
    }

    public async Task<List<Episode>> GetEpisodesAsync(Podcast podcast)
    {
        // 1. Hämta från DB
        var podFromDb = await _podcastRepo.GetByIdAsync(podcast.Id);

        if (podFromDb != null && podFromDb.Episodes.Any())
            return podFromDb.Episodes;

        // 2. Fallback: hämta från RSS
        var episodes = await _rss.GetRSSPod(podcast.RssUrl);

        // 3. Spara i DB
        podcast.Episodes = episodes;
        await _podcastRepo.UpdateAsync(podcast);

        return episodes;
    }


    public async Task SavePodcastAsync(Podcast podcast)
    {
        await _podcastRepo.AddAsync(podcast);
    }

    public async Task<List<Podcast>> GetAllPodcastsAsync()
    {
        return await _podcastRepo.GetAllAsync();
    }

    public async Task DeletePodcastAsync(string id)
    {
        await _podcastRepo.DeleteAsync(id);
    }
    public async Task AddCategoryAsync(string name)
    {
        await _podcastRepo.AddCategoryAsync(name);
    }

    public async Task<List<Category>> GetAllCategoriesAsync()
    {
        return await _podcastRepo.GetAllCategoriesAsync();
    }

    public async Task AddCategoryToPodcastAsync(string podcastId, string categoryId)
    {
        await _podcastRepo.AddCategoryToPodcastAsync(podcastId, categoryId);
    }

    public async Task RemoveCategoryFromPodcastAsync(string podcastId, string categoryId)
    {
        await _podcastRepo.RemoveCategoryFromPodcastAsync(podcastId, categoryId);
    }

    public async Task ChangeNamePodcastAsync(string podcastId, string newName)
    {
        await _podcastRepo.ChangeNamePodcastAsync(podcastId, newName);
    }

    public async Task ChangeCategoryNameAsync(string categoryId, string newName)
    {
        // Vi lägger ingen extra affärslogik här, utan bara skickar vidare till DAL
        await _podcastRepo.ChangeCategoryNameAsync(categoryId, newName);
    }

    // NY IMPLEMENTERING FÖR ATT BYTA KATEGORI
    public async Task ChangeCategoryPodcastAsync(Podcast podcast, List<Category> newCategories)
    {
        podcast.Categories = newCategories;
        await _podcastRepo.UpdateAsync(podcast);
    }

    public async Task DeleteCategoryAsync(string categoryId)
    {
        await _podcastRepo.DeleteCategoryAsync(categoryId);
    }


}
