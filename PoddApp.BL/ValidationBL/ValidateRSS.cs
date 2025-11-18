using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PoddApp.BL.ValidationBL
{
    public class ValidateRSS
    {
        private readonly ValidateUrl urlValidator = new ValidateUrl();

        public async Task<ValidateUrl> ValidatePodcastRssAsync(String rssUrl)
        {
            var result = new ValidateUrl();

            var urlCheck = await this.urlValidator.ValidateUrlAsync(rssUrl); //testar att länken nås

            if (!urlCheck.IsValid)
            {
                foreach (var error in urlCheck.Errors)
                    result.AddError(error);

                return result;
            }

            try
            {
                using var reader = XmlReader.Create(rssUrl); //kollar att det är en RSS podcast länk
                var feed = SyndicationFeed.Load(reader);

                if (feed == null)
                {
                    result.AddError("länken är inte giltig RSS-länk");
                    return result;
                }
                
                if (feed.Items == null)
                {
                    result.AddError("Ej Podcast RSS länk");
                    return result;
                }
            }
            catch (XmlException)
            {
                result.AddError("Länken är inte giltig");
            }
            catch (Exception)
            {
                result.AddError("Kunde inte läsa RSS");
            }

            return result;
        }
    }
}
