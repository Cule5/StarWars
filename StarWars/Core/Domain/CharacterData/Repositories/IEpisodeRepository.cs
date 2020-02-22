using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.CharacterData.Repositories
{
    public interface IEpisodeRepository
    {
        Task<Episode> GetAsync(Guid id);
        Task<Episode> GetByTitleAsync(string title);
        Task AddAsync(Episode episode);
    }
}
