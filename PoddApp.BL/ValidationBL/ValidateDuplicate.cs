using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoddApp.DAL;
using PoddApp.Models;

namespace PoddApp.BL.ValidationBL
{
    public class ValidateDuplicate
    {
        private readonly PodcastRepository podcastRepository;

        public ValidateDuplicate(PodcastRepository podcastRepository)
        {
            this.podcastRepository = podcastRepository;
        }

        public async Task<ValidateUrl> ValidateDuplicateAsync(String rssUrl)
        {
            var result = new ValidateUrl();

            var existing = await this.podcastRepository.GetByRssUrlAsync(rssUrl);

            if (existing != null)
            {
                result.AddError("Denna podcast finns redan sparad");
            }

            return result;
        }
    }
}
