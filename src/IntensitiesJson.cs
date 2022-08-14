namespace Nullforce.Api.Derpibooru.JsonModels;

public class IntensitiesJson : JsonBase
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
