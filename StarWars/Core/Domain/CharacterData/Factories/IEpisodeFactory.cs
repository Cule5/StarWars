using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.CharacterData.Factories
{
    public interface IEpisodeFactory
    {
        Task<Episode> CreateAsync(Guid id,string title);
    }
}
