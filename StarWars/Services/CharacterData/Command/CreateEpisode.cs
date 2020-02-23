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
        public CreateEpisode()
        {

        }
    }
}
