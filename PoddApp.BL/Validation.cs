using System;
using System.Net.Http;
using System.ServiceModel.Syndication;
using System.Threading.Tasks;
using System.Xml;
using PoddApp.DAL;

namespace PoddApp.BL
{
    public class Validation : IValidation
    {
        private readonly IPodcastRepo podcastRepo;
        private readonly HttpClient http;

        public Validation(IPodcastRepo podcastRepo)
        {
            this.podcastRepo = podcastRepo;
            this.http = new HttpClient();
            this.http.Timeout = TimeSpan.FromSeconds(2);
        }

        public async Task<string?> ValidateUrlAsync(string url)
        {
            try
            {
                var response = await http.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                    return $"Server error: {response.StatusCode}";
            }
            catch (Exception)
            {
                return "Fel adress";
            }

            return null;
        }

        public async Task<string?> ValidateRssAsync(string rssUrl)
        {
            var urlError = await ValidateUrlAsync(rssUrl);
            if (urlError != null)
                return urlError;

            try
            {
                using var reader = XmlReader.Create(rssUrl);
                var feed = SyndicationFeed.Load(reader);

                if (feed == null)
                    return "Använde RSS länk";

                if (feed.Items == null)
                    return "Ej podcast länk";
            }
            catch (Exception)
            {
                return "Felaktig länk";
            }

            return null;
        }

        public async Task<string?> ValidateDuplicateAsync(string rssUrl)
        {
            var existing = await podcastRepo.GetByRssUrlAsync(rssUrl);

            if (existing != null)
                return "Podcast är redan sparad";

            return null;
        }


        public string? ValidateEmpty(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "Obligatoriskt fält";

            return null;
        }
    }
}

