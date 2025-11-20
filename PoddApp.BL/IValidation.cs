using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.BL
{
    public interface IValidation
    {
        Task<string?> ValidateUrlAsync(string url);
        Task<string?> ValidateRssAsync(string rssurl);
        Task<string?> ValidateDuplicateAsync(string rssurl);
        string? ValidateEmpty(string value);
    }
}
