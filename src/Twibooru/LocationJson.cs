namespace Nullforce.Api.JsonModels.Twibooru;

public class LocationJson : JsonBase
{
    [JsonPropertyName("id_at_location")]
    public int Id { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("url_at_location")]
    public string Url { get; set; }
}
