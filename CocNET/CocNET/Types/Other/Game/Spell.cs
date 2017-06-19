using Newtonsoft.Json;

namespace CocNET.Types.Other.Game
{
    public class Spell : BadRequest
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("maxLevel")]
        public int MaxLevel { get; set; }
        [JsonProperty("village")]
        public string Village { get; set; }
    }
}
