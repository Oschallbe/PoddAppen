using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.DAL
{
    public interface IPodcastRepo
    {
        Task<List<Podcast>> GetAllAsync();
        Task AddAsync(Podcast podcast);
        Task<Podcast?> GetByRssUrlAsync(string rssUrl);
        Task UpdateAsync(Podcast podcast);
        Task DeleteAsync(string id);


    }
}
