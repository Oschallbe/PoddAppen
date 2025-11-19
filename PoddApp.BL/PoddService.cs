using PoddApp.DAL;
using PoddApp.Models;

public class PoddService
{
    private readonly RSSPodd aRssPodd;

    public PoddService(RSSPodd rssPodd)
    {
        aRssPodd = rssPodd;
    }

    public async Task SetPodcastImageAsync(Podcast podcast)
    {
        podcast.ImageUrl = await aRssPodd.GetPodcastImageUrl(podcast.RssUrl);
    }

    public async Task SetPodcastTitleAsync(Podcast podcast)
    {
        podcast.Name = await aRssPodd.GetPodcastTitle(podcast.RssUrl);
    }

    public async Task SetPodcastDescriptionAsync(Podcast podcast)
    {
        podcast.Description = await aRssPodd.GetPodcastDescription(podcast.RssUrl);
    }

    public async Task<List<Episode>> getEpisodes(Podcast aPodcast)
    {
        var episodes = await aRssPodd.GetRSSPod(aPodcast.RssUrl);

        foreach (var episode in episodes)
        {
            episode.Link = aPodcast.RssUrl;
            episode.Id = aPodcast.Id + "-->" + episode.Id;
        }

        return episodes;
    }
}
