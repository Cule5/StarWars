using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Services.Common.Command;

namespace Services.CharacterData.Command
{
    public class CreateEpisode:ICommand
    {
        [JsonConstructor]
        public CreateEpisode(Guid id,string title)
        {
            Id = id;
            Title = title;
        }
        public Guid Id { get; }
        public string Title { get; }
    }
}
