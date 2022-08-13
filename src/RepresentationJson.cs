using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels;

public class RepresentationsJson
{
    [JsonPropertyName("full")]
    public string Full { get; set; }
    [JsonPropertyName("large")]
    public string Large { get; set; }
    [JsonPropertyName("medium")]
    public string Medium { get; set; }
    [JsonPropertyName("small")]
    public string Small { get; set; }
    [JsonPropertyName("tall")]
    public string Tall { get; set; }
    [JsonPropertyName("thumb")]
    public string Thumb { get; set; }
    [JsonPropertyName("thumb_small")]
    public string ThumbSmall { get; set; }
    [JsonPropertyName("thumb_tiny")]
    public string ThumbTiny { get; set; }
}
