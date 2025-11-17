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

        public async Task<List<Models.Episode>> getEpisodes(Episode anEpisode)
        {
            var episodes = await aRssPodd.GetRSSPod(anEpisode.Link);

            foreach(var episode in episodes) {
                episode.Link = anEpisode.Link;
                episode.Id = anEpisode.Id + "-->" + episode.Id;
            }
            return episodes;
        }


    }
}
