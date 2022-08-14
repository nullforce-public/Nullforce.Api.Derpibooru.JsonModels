namespace Nullforce.Api.JsonModels.Twibooru;

public class TagJson : JsonBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("aliased_tag")]
    public string AliasedTag { get; set; }

    [JsonPropertyName("aliases")]
    public string[] Aliases { get; set; }

    /// <summary>
    /// The category class of this tag. One of "character", "content-fanmade", "content-official", "error", "oc", "origin", "rating", "species", "spoiler".
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("implied_by_tags")]
    public string[] ImpliedByTags { get; set; }

    [JsonPropertyName("implied_tags")]
    public string[] ImpliedTags { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("name_in_namespace")]
    public string NameInNamespace { get; set; }

    [JsonPropertyName("namespace")]
    public string Namespace { get; set; }

    [JsonPropertyName("posts")]
    public int PostCount { get; set; }

    [JsonPropertyName("short_description")]
    public string ShortDescription { get; set; }

    [JsonPropertyName("slug")]
    public string Slug { get; set; }
}
