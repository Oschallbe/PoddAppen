using PoddApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoddApp.BL
{
    public interface IPoddService
    {
        Task SetPodcastImageAsync(Podcast podcast);
        Task SetPodcastTitleAsync(Podcast podcast);
        Task SetPodcastDescriptionAsync(Podcast podcast);

        Task<List<Episode>> GetEpisodesAsync(Podcast podcast);

        Task SavePodcastAsync(Podcast podcast);
        Task<List<Podcast>> GetAllPodcastsAsync();
        Task DeletePodcastAsync(int id);
        Task AddCategoryAsync(string name);


    }
}
