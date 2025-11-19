using PoddApp.DAL;
using PoddApp.Models;
using System.Runtime.CompilerServices;

//Alla metoder som gör någonting med databasen ska ligga här. tex spara lägga till
//T.ex Add new pod(UI) - > Metoden i PoddService(Här i ligger en metod som går till interface ->
//repository (DAL) som sparar podden i databasen

public class PoddService
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
            episode.Link = podcast.RssUrl;
            episode.Id = podcast.Id + "-->" + episode.Id;
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