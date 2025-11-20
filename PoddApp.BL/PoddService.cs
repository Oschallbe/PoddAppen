using PoddApp.BL;
using PoddApp.DAL;
using PoddApp.Models;

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
}
