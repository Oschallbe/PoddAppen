using PoddApp.DAL;
using PoddApp.Models;
using System.ServiceModel.Syndication;
using System.Xml;

namespace PoddApp.BL
{
    public class PoddService
    {
        private RSSPodd aRssPodd;

        public PoddService(RSSPodd rssPodd)
        {
            this.aRssPodd = rssPodd;
        }

        public async Task<List<Models.Episode>> getEpisodes(Podcast aPodcast)
        {
            var episodes = await aRssPodd.GetRSSPod(aPodcast.RssUrl);

            foreach(var episode in episodes) {
                episode.Link = aPodcast.RssUrl;
                episode.Id = aPodcast.Id + "-->" + episode.Id;
            }
            return episodes;
        }

        public async Task SetPodcastImageAsync(Podcast podcast)
        {  
            var imgUrl = await aRssPodd.GetPodcastImageUrl(podcast.RssUrl);
            podcast.ImageUrl = imgUrl;
        }

        public async Task SetPodcastTitleAsync(Podcast podcast)
        {
            var podcastTitle = await aRssPodd.GetPodcastTitle(podcast.RssUrl);
            podcast.Name = podcastTitle;
        }

        public async Task SetPodcastDescriptionAsync(Podcast podcast)
        {
            var podcastDescription = await aRssPodd.GetPodcastDescription(podcast.RssUrl);
            podcast.Description = podcastDescription;
        }

        public async Task SetEpisodeDescriptionAsync(Episode episode)
        {
            var episodeDescription = await aRssPodd.GetPodcastDescription(episode.Link);
            episode.Description = episodeDescription;
        }
    }
}
