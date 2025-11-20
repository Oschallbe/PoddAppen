using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel.Syndication;
using System.Xml;
using PoddApp.Models;
using System.Xml.Linq;

namespace PoddApp.DAL
{
    public class RSSPodd : IRssReader
    {
        private HttpClient aHttpClient;


        public RSSPodd(HttpClient httpClient)
        {
            this.aHttpClient = httpClient;
        }

        public async Task<List<Episode>> GetRSSPod(string rssUrl)
        {
            Stream dataStream = await aHttpClient.GetStreamAsync(rssUrl);
            var settings = new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Ignore,
                XmlResolver = null
            };
            using var myReader = XmlReader.Create(dataStream, settings);
            SyndicationFeed dataFlow = SyndicationFeed.Load(myReader);

            myReader.Dispose();
            dataStream.Dispose();
            List<Episode> episodes = new List<Episode>();

            foreach (SyndicationItem item in dataFlow.Items)
            {
                Episode episode = new Episode();
                episode.Title = item.Title.Text;
                episode.Description = item.Summary.Text;
                episode.PublishedDate = item.PublishDate.DateTime;
                episode.Link = item.Links[0].Uri.ToString();
                episodes.Add(episode);
            }
            return episodes;
        }

        public async Task<string?> GetPodcastImageUrl(string rssUrl)
        {

            Stream dataStream = await aHttpClient.GetStreamAsync(rssUrl);
            using var myReader = XmlReader.Create(dataStream);
            var feed = SyndicationFeed.Load(myReader);

            string? imageUrl = feed.ImageUrl?.ToString();

            if (string.IsNullOrEmpty(imageUrl))
            {
                XNamespace itunesNs = "http://www.itunes.com/dtds/podcast-1.0.dtd";
                var itunesImage = feed.ElementExtensions
                    .ReadElementExtensions<XElement>("image", itunesNs.NamespaceName)
                    .FirstOrDefault();
                if(itunesImage != null)
                {
                    imageUrl = (string?)itunesImage.Attribute("href");
                }
            }
            return imageUrl;
        }

        public async Task<string?> GetPodcastTitle(string rssUrl)
        {
            Stream dataStream = await aHttpClient.GetStreamAsync(rssUrl);
            using var reader = XmlReader.Create(dataStream);
            var feed = SyndicationFeed.Load(reader);

            return feed.Title?.Text;
        }

        public async Task<string?> GetPodcastDescription(string rssUrl)
        {
            Stream dataStream = await aHttpClient.GetStreamAsync(rssUrl);
            using var reader = XmlReader.Create(dataStream);
            var feed = SyndicationFeed.Load(reader);

            string? desc = feed.Description?.Text;

            if (string.IsNullOrEmpty(desc))
            {
                foreach (var ext in feed.ElementExtensions)
                {
                    if (ext.OuterName.Equals("summary", StringComparison.OrdinalIgnoreCase))
                    {
                        var x = ext.GetObject<System.Xml.Linq.XElement>();
                        desc = x.Value;
                    }
                }
            }

            return desc;
        }

    }
}
