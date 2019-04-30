using System;
using Newtonsoft.Json;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class ImageJson
    {
        public string Id { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("first_seen_at")]
        public DateTime FirstSeenAt { get; set; }
        public int Score { get; set; }
        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        [JsonProperty("file_name")]
        public string Filename { get; set; }
        public string Description { get; set; }
        public string Uploader { get; set; }
        [JsonProperty("uploader_id")]
        public int? UploaderId { get; set; }
        [JsonProperty("image")]
        public string ImageUri { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public int Faves { get; set; }
        public string Tags { get; set; }
        [JsonProperty("tag_ids")]
        public int[] TagIds { get; set; }
        [JsonProperty("aspect_ratio")]
        public double AspectRatio { get; set; }
        [JsonProperty("original_format")]
        public string OriginalFormat { get; set; }
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }
        [JsonProperty("sha512_hash")]
        public string SHA512Hash { get; set; }
        [JsonProperty("orig_sha512_hash")]
        public string OriginalSHA512Hash { get; set; }
        [JsonProperty("source_url")]
        public string SourceUri { get; set; }
        public RepresentationsJson Representations { get; set; }
        [JsonProperty("is_rendered")]
        public bool IsRendered { get; set; }
        [JsonProperty("is_optimized")]
        public bool IsOptimized { get; set; }
    }
}
