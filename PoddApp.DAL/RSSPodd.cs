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

        public async Task<List<Episode>> HentRSSFeed(string rssUrl)
        {
            Stream dataStream = await aHttpClient.GetStreamAsync(rssUrl);
            XmlReader myReader = XmlReader.Create(dataStream);
            SyndicationFeed dataFlow = SyndicationFeed.Load(myReader);
        }

    }
}
