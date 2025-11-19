using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public interface IRssReader
    {
        Task<List<Episode>> GetRSSPod(string rssUrl);
        Task<string?> GetPodcastImageUrl(string rssUrl);
        Task<string?> GetPodcastTitle(string rssUrl);
        Task<string?> GetPodcastDescription(string rssUrl);
    }
}
