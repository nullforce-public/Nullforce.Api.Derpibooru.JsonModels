using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class IntensitiesJson
    {
        [JsonPropertyName("ne")]
        public double NE { get; set; }
        [JsonPropertyName("nw")]
        public double NW { get; set; }
        [JsonPropertyName("se")]
        public double SE { get; set; }
        [JsonPropertyName("sw")]
        public double SW { get; set; }
    }
}
