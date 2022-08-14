namespace Nullforce.Api.JsonModels.Twibooru;

public class PostJson : JsonBase
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("deletion_reason")]
    public string DeletionReason { get; set; }

    [JsonPropertyName("duplicate_of")]
    public int DuplicateOf { get; set; }

    [JsonPropertyName("first_seen_at")]
    public DateTime FirstSeenAt { get; set; }

    [JsonPropertyName("hidden_from_users")]
    public bool HiddenFromUsers { get; set; }

    [JsonPropertyName("locations")]
    public LocationJson[] Locations { get; set; }

    /// <summary>
    /// The type of media associated with this post. One of "paste", "image".
    /// </summary>
    [JsonPropertyName("media_type")]
    public string MediaType { get; set; }

    [JsonPropertyName("orig_sha512_hash")]
    public string OriginalSHA512Hash { get; set; }

    [JsonPropertyName("processed")]
    public bool Processed { get; set; }

    [JsonPropertyName("sha512_hash")]
    public string SHA512Hash { get; set; }

    [JsonPropertyName("source_url")]
    public string SourceUrl { get; set; }

    [JsonPropertyName("tag_ids")]
    public int[] TagIds { get; set; }

    [JsonPropertyName("tags")]
    public string[] Tags { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    // Non-hidden Post
    [JsonPropertyName("comment_count")]
    public int CommentCount { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("downvotes")]
    public int Downvotes { get; set; }

    [JsonPropertyName("faves")]
    public int Favorites { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("size")]
    public long Size { get; set; }

    [JsonPropertyName("upvotes")]
    public int Upvotes { get; set; }

    [JsonPropertyName("wilson_score")]
    public double WilsonScore { get; set; }

    // Image Post
    [JsonPropertyName("animated")]
    public bool Animated { get; set; }

    [JsonPropertyName("aspect_ratio")]
    public double AspectRatio { get; set; }

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    /// <summary>
    /// The file extension of the image. One of "gif", "jpg", "jpeg", "png", "svg", "webm", "mp4".
    /// </summary>
    [JsonPropertyName("format")]
    public string Format { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("intensities")]
    public IntensitiesJson Intensities { get; set; }

    /// <summary>
    /// The MIME type of this image. One of "image/gif", "image/jpeg", "image/png", "image/svg+xml", "video/webm", "video/mp4".
    /// </summary>
    [JsonPropertyName("mime_type")]
    public string MimeType { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("representations")]
    public RepresentationsJson Representations { get; set; }

    [JsonPropertyName("thumbnails_generated")]
    public bool ThumbnailsGenerated { get; set; }

    [JsonPropertyName("view_url")]
    public string ViewUrl { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }
}
