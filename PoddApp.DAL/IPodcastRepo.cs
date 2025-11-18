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
        Task AddAsync(Podcast podcast);
        Task<List<Podcast>> GetAllAsync();

    }
}
