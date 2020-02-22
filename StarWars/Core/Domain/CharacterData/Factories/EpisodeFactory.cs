using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.CharacterData.Repositories;

namespace Core.Domain.CharacterData.Factories
{
    public class EpisodeFactory:IEpisodeFactory
    {
        private readonly IEpisodeRepository _episodeRepository;
        public EpisodeFactory(IEpisodeRepository episodeRepository)
        {
            _episodeRepository = episodeRepository;
        }
        public async Task<Episode> CreateAsync(Guid id,string title)
        {
            var dbEpisode = await _episodeRepository.GetByTitleAsync(title);
            if(dbEpisode!=null)
                throw new Exception("Episode with given title already exists");
            return new Episode(id,title);
        }
    }
}
