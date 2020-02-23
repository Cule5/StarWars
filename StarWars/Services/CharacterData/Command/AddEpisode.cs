using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.Common.Command;

namespace Services.CharacterData.Command
{
    public class AddEpisode : ICommand
    {
        [JsonConstructor]
        public AddEpisode(Guid id, string title, IEnumerable<Guid> characters)
        {
            Id = id;
            Title = title;
            Characters = characters;
        }
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public IEnumerable<Guid> Characters { get; private set; }
    }
}
