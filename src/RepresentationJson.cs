using Newtonsoft.Json;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class RepresentationsJson
    {
        [JsonProperty("thumb_tiny")]
        public string ThumbTiny { get; set; }
        [JsonProperty("thumb_small")]
        public string ThumbSmall { get; set; }
        public string Thumb { get; set; }
        public string Small { get; set; }
        public string Medium { get; set; }
        public string Large { get; set; }
        public string Tall { get; set; }
        public string Full { get; set; }
    }
}
