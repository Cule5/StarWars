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
        Task CreateFriendshipAsync(Guid characterId, IEnumerable<Guid> friends);
        Task AddEpisodesToCharacter(Guid characterId,IEnumerable<Guid>episodes);
        Task DeleteFriendship(Guid characterA,Guid characterB);
    }
}
