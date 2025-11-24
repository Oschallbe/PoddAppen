    using System;
    using System.Net.Http;
    using System.ServiceModel.Syndication;
    using System.Threading.Tasks;
    using System.Xml;
    using PoddApp.DAL;
    using PoddApp.BL;
    using PoddApp.Models;

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
                this.http.Timeout = TimeSpan.FromSeconds(5);
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
                using var stream = await http.GetStreamAsync(rssUrl);

                var settings = new XmlReaderSettings
                {
                    DtdProcessing = DtdProcessing.Ignore,
                    XmlResolver = null
                };

                using var reader = XmlReader.Create(stream, settings);

                var feed = SyndicationFeed.Load(reader);

                if (feed == null)
                    return "Länk är inte ett RSS-flöde.";

                if (feed.Items == null || !feed.Items.Any())
                    return "Länken verkar vara ett tomt RSS-flöde.";

                //Podcast validering
                bool hasAudio = feed.Items.Any(item =>
                    item.Links.Any(l =>
                        l.Uri.AbsoluteUri.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase) ||
                        l.Uri.AbsoluteUri.EndsWith(".m4a", StringComparison.OrdinalIgnoreCase) ||
                        l.RelationshipType == "enclosure"
                    )
                );

                if (!hasAudio)
                    return "RSS-flödet är inte en podcast.";
            }
            catch (Exception)
            {
                return "Felaktig RSS-länk.";
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

