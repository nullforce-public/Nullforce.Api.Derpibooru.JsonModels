using System;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class ImageJson
    {
        public string Id { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonPropertyName("first_seen_at")]
        public DateTime FirstSeenAt { get; set; }
        public int Score { get; set; }
        [JsonPropertyName("comment_count")]
        public int CommentCount { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        [JsonPropertyName("file_name")]
        public string Filename { get; set; }
        public string Description { get; set; }
        public string Uploader { get; set; }
        [JsonPropertyName("uploader_id")]
        public int? UploaderId { get; set; }
        [JsonPropertyName("image")]
        public string ImageUri { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public int Faves { get; set; }
        public string Tags { get; set; }
        [JsonPropertyName("tag_ids")]
        public int[] TagIds { get; set; }
        [JsonPropertyName("aspect_ratio")]
        public double AspectRatio { get; set; }
        [JsonPropertyName("original_format")]
        public string OriginalFormat { get; set; }
        [JsonPropertyName("mime_type")]
        public string MimeType { get; set; }
        [JsonPropertyName("sha512_hash")]
        public string SHA512Hash { get; set; }
        [JsonPropertyName("orig_sha512_hash")]
        public string OriginalSHA512Hash { get; set; }
        [JsonPropertyName("source_url")]
        public string SourceUri { get; set; }
        public RepresentationsJson Representations { get; set; }
        [JsonPropertyName("is_rendered")]
        public bool IsRendered { get; set; }
        [JsonPropertyName("is_optimized")]
        public bool IsOptimized { get; set; }
    }
}
