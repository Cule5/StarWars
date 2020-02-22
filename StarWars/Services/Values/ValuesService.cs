using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Domain.Character.Repositories;

namespace Services.Values
{
    public class ValuesService:IValuesService
    {
        private readonly ICharacterRepository _characterRepository;
        public ValuesService(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }
        public Task AddCharacterAsync()
        {
            throw new NotImplementedException();
        }
    }
}
