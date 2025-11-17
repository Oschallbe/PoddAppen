using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel.Syndication;
using System.Xml;
using PoddApp.Models;

namespace PoddApp.DAL
{
    public class RSSPodd
    {
        private HttpClient aHttpClient;


        public RSSPodd(HttpClient httpClient)
        {
            this.aHttpClient = httpClient;
        }

        public async Task<List<Episode>> GetRSSPod(string rssUrl)
        {
            Stream dataStream = await aHttpClient.GetStreamAsync(rssUrl);
            XmlReader myReader = XmlReader.Create(dataStream);
            SyndicationFeed dataFlow = SyndicationFeed.Load(myReader);

            myReader.Dispose();
            dataStream.Dispose();
            List<Episode> episodes = new List<Episode>();

            foreach(SyndicationItem item in dataFlow.Items)
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

    }
}
