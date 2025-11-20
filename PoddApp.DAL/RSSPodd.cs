using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;
using PoddApp.Models;

namespace PoddApp.DAL
{
    public class RSSPodd : IRssReader
    {
        private readonly HttpClient _http;

        public RSSPodd(HttpClient httpClient)
        {
            _http = httpClient;
        }

        public async Task<List<Episode>> GetRSSPod(string rssUrl)
        {
            using var data = await _http.GetStreamAsync(rssUrl);
            using var reader = XmlReader.Create(data);

            var feed = SyndicationFeed.Load(reader);
            var episodes = new List<Episode>();

            foreach (var item in feed.Items)
            {
                var ep = new Episode
                {
                    Id = item.Id,
                    Title = item.Title?.Text ?? "",
                    Description = item.Summary?.Text ?? "",
                    PublishedDate = item.PublishDate.DateTime,
                    Link = item.Links.FirstOrDefault()?.Uri.ToString() ?? ""
                };

                episodes.Add(ep);
            }

            return episodes;
        }

        public async Task<string?> GetPodcastImageUrl(string rssUrl)
        {
            using var data = await _http.GetStreamAsync(rssUrl);
            using var reader = XmlReader.Create(data);

            var feed = SyndicationFeed.Load(reader);

            var url = feed.ImageUrl?.ToString();
            if (!string.IsNullOrEmpty(url))
                return url;

            XNamespace itunes = "http://www.itunes.com/dtds/podcast-1.0.dtd";
            var img = feed.ElementExtensions.ReadElementExtensions<XElement>("image", itunes.NamespaceName).FirstOrDefault();

            return img?.Attribute("href")?.Value;
        }

        public async Task<string?> GetPodcastTitle(string rssUrl)
        {
            using var data = await _http.GetStreamAsync(rssUrl);
            using var reader = XmlReader.Create(data);

            var feed = SyndicationFeed.Load(reader);
            return feed.Title?.Text;
        }

        public async Task<string?> GetPodcastDescription(string rssUrl)
        {
            using var data = await _http.GetStreamAsync(rssUrl);
            using var reader = XmlReader.Create(data);

            var feed = SyndicationFeed.Load(reader);

            var desc = feed.Description?.Text;
            if (!string.IsNullOrEmpty(desc))
                return desc;

            foreach (var ext in feed.ElementExtensions)
            {
                if (ext.OuterName == "summary")
                {
                    var el = ext.GetObject<XElement>();
                    return el.Value;
                }
            }

            return null;
        }

        public async Task<string?> GetEpisodeImageUrl(string rssUrl, string episodeId)
        {
            using var data = await _http.GetStreamAsync(rssUrl);
            using var reader = XmlReader.Create(data);

            var feed = SyndicationFeed.Load(reader);

            var ep = feed.Items.FirstOrDefault(i => i.Id == episodeId);
            if (ep == null)
                return null;

            XNamespace itunes = "http://www.itunes.com/dtds/podcast-1.0.dtd";
            var img = ep.ElementExtensions.ReadElementExtensions<XElement>("image", itunes.NamespaceName).FirstOrDefault();

            return img?.Attribute("href")?.Value;
        }
    }
}
