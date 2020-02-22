using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData;
using Core.Domain.CharacterData.Repositories;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.CharacterData
{
    public class EpisodeRepository:IEpisodeRepository
    {
        private readonly AppDbContext _dbContext;
        public EpisodeRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Episode> GetAsync(Guid id)
        {
            return await _dbContext.Episodes.FindAsync(id);
        }

        public async Task<Episode> GetByTitleAsync(string title)
        {
            return await _dbContext.Episodes.FirstOrDefaultAsync(episode=>episode.Title.Equals(title));
        }

        public async Task AddAsync(Episode episode)
        {
            await _dbContext.AddAsync(episode);
            await _dbContext.SaveChangesAsync();
        }
    }
}
