using PoddApp.DAL;
using PoddApp.Models;
using PoddApp.BL.ValidationBL;

namespace PoddApp.BL
{
    public class PoddService
    {
        private RSSPodd aRssPodd;
        private readonly ValidateRSS rssValidator = new ValidateRSS();

        public PoddService(RSSPodd rssPodd)
        {
            this.aRssPodd = rssPodd;
        }

        public async Task<ValidateUrl> ValidatePodcastRssAsync(Podcast podcast)
        {
            return await this.rssValidator.ValidatePodcastRssAsync(podcast.RssUrl);
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
