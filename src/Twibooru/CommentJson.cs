namespace Nullforce.Api.JsonModels.Twibooru;

public class CommentJson : JsonBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("hidden_from_users")]
    public bool HiddenFromUsers { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }
}
