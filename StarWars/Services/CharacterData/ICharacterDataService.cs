using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.CharacterData.Dto;

namespace Services.CharacterData
{
    public interface ICharacterDataService
    {
        Task AddCharacterAsync(ExtendedCharacterDto extendedCharacterDto);
        Task AddEpisodeAsync();
    }
}
