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



}
}
