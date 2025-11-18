using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace PoddApp.BL.ValidationBL
{
    public class ValidateUrl
    {

        public List<String> Errors { get; } = new List<String>();
        public bool IsValid => Errors.Count == 0;

        public void AddError(String message)
        {
          this.Errors.Add(message);
        }
        public async Task<ValidateUrl> ValidateUrlAsync(String url)
        {
            var result = new ValidateUrl();

            try
            {
                using var client = new HttpClient();
                client.Timeout = TimeSpan.FromSeconds(2);

                var response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    result.AddError($"Servern svarade med felkod: {response.StatusCode}");
                }
            }
            catch (TaskCanceledException)
            {
                result.AddError("Servern svarade inte");
            }
            catch (HttpRequestException)
            {
                result.AddError("Kunde inte nå länken, är adressen korrekt?");
            }
            catch (Exception)
            {
                result.AddError("Fel vid kontroll av länken");
            }

            return result;
        }
    }
}

