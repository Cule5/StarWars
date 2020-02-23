using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.CharacterData.Dto;

namespace Services.CharacterData
{
    public interface ICharacterDataService
    {
        Task CreateCharacterAsync(Guid id,string name);
        Task CreateEpisodeAsync(Guid id,string title);
    }
}
