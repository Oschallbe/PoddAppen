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
        var episodes = await _rss.GetRSSPod(podcast.RssUrl);

        foreach (var episode in episodes)
        {
            var originalId = episode.Id;

            var episodeImage = await _rss.GetEpisodeImageUrl(podcast.RssUrl, originalId);

            episode.ImageUrl = episodeImage ?? podcast.ImageUrl;

            episode.Id = podcast.Id + "-->" + originalId;
            episode.Link = podcast.RssUrl;
        }

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

    public async Task DeleteEpisodeAsync(string podcastId, string episodeId)
    {
        await _podcastRepo.DeleteEpisodeAsync(podcastId, episodeId);
    }

    public async Task AddCategoryAsync(string name)
    {
        await _podcastRepo.AddCategoryAsync(name);
    }

    // 🔥 NYA METODER — dem du saknar

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
}
