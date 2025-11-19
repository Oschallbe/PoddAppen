using PoddApp.DAL;
using PoddApp.Models;
using System.Runtime.CompilerServices;

//Alla metoder som gör någonting med databasen ska ligga här. tex spara lägga till
//T.ex Add new pod(UI) - > Metoden i PoddService(Här i ligger en metod som går till interface ->
//repository (DAL) som sparar podden i databasen

public class PoddService
{
    private readonly RSSPodd aRssPodd;
    private readonly IPodcastRepo _podcastRepo;

    public PoddService(RSSPodd rssPodd, IPodcastRepo podcastRepo)
    {
        aRssPodd = rssPodd;
        _podcastRepo = podcastRepo;
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

    public async Task SavePodcastAsync(Podcast podcast)
    {
        await _podcastRepo.AddAsync(podcast);
    }

    public async Task<List<Podcast>> GetAllPodcastsAsync()
    {
        return await _podcastRepo.GetAllAsync();
    }
}
