using Newtonsoft.Json;

namespace CocNET.Types.Other.Game
{
    public class Season : BadRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("rank")]
        public int Rank { get; set; }
        [JsonProperty("trophies")]
        public int Trophies { get; set; }
    }
}
