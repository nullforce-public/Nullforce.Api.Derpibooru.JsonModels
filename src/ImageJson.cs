using System;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class ImageJson
    {
        /// <summary>
        /// The image's ID.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Whether the image is animated.
        /// </summary>
        [JsonPropertyName("animated")]
        public bool IsAnimated { get; set; }

        /// <summary>
        /// The image's width divided by its height.
        /// </summary>
        [JsonPropertyName("aspect_ratio")]
        public double AspectRatio { get; set; }

        /// <summary>
        /// The number of comments made on the image.
        /// </summary>
        [JsonPropertyName("comment_count")]
        public int CommentCount { get; set; }

        /// <summary>
        /// The creation time, in UTC, of the image.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The hide reason for the image, or null if none provided. This will only have a value on images which are deleted for a rule violation.
        /// </summary>
        [JsonPropertyName("deletion_reason")]
        public string DeletionReason { get; set; }

        /// <summary>
        /// The image's description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The number of downvotes the image has.
        /// </summary>
        [JsonPropertyName("downvotes")]
        public int DownvoteCount { get; set; }

        /// <summary>
        /// The ID of the target image, or null if none provided. This will only have a value on images which are merged into another image.
        /// </summary>
        [JsonPropertyName("duplicate_of")]
        public int? DuplicateOf { get; set; }

        /// <summary>
        /// The number of seconds the image lasts, if animated, otherwise .04.
        /// </summary>
        [JsonPropertyName("duration")]
        public double Duration { get; set; }

        /// <summary>
        /// The number of faves the image has.
        /// </summary>
        [JsonPropertyName("faves")]
        public int FaveCount { get; set; }

        /// <summary>
        /// The time, in UTC, this image was first seen (before any duplicate merging).
        /// </summary>
        [JsonPropertyName("first_seen_at")]
        public DateTime FirstSeenAt { get; set; }

        /// <summary>
        /// The file extension of this image. One of "gif", "jpeg", "jpg", "png", "svg", "webm".
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// The image's height, in pixels.
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// Whether this image is hidden. An image is hidden if it is merged or deleted for a rule violation.
        /// </summary>
        [JsonPropertyName("hidden_from_users")]
        public bool HiddenFromUsers { get; set; }

        /// <summary>
        /// Optional object of internal image intensity data for deduplication purposes. May be null if intensities have not yet been generated.
        /// </summary>
        [JsonPropertyName("intensities")]
        public IntensitiesJson Intensities { get; set; }

        /// <summary>
        /// The MIME type of this image. One of "image/gif", "image/jpeg", "image/png", "image/svg+xml", "video/webm".
        /// </summary>
        [JsonPropertyName("mime_type")]
        public string MimeType { get; set; }

        /// <summary>
        /// The filename that this image was uploaded with.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The SHA512 hash of this image as it was originally uploaded.
        /// </summary>
        [JsonPropertyName("orig_sha512_hash")]
        public string OriginalSHA512Hash { get; set; }

        /// <summary>
        /// Whether the image has finished optimization.
        /// </summary>
        [JsonPropertyName("processed")]
        public bool IsProcessed { get; set; }

        /// <summary>
        /// A mapping of representation names to their respective URLs. Contains the keys "full", "large", "medium", "small", "tall", "thumb", "thumb_small", "thumb_tiny".
        /// </summary>
        [JsonPropertyName("representations")]
        public RepresentationsJson Representations { get; set; }

        /// <summary>
        /// The image's number of upvotes minus the image's number of downvotes.
        /// </summary>
        [JsonPropertyName("score")]
        public int Score { get; set; }

        /// <summary>
        /// The SHA512 hash of this image after it has been processed.
        /// </summary>
        [JsonPropertyName("sha512_hash")]
        public string SHA512Hash { get; set; }

        /// <summary>
        /// The current source URL of the image.
        /// </summary>
        [JsonPropertyName("source_url")]
        public string SourceUri { get; set; }

        /// <summary>
        /// Whether this image is hit by the current filter.
        /// </summary>
        [JsonPropertyName("spoilered")]
        public bool IsSpoilered { get; set; }

        /// <summary>
        /// The number of tags present on this image.
        /// </summary>
        [JsonPropertyName("tag_count")]
        public int TagCount { get; set; }

        /// <summary>
        /// A list of tag IDs this image contains.
        /// </summary>
        [JsonPropertyName("tag_ids")]
        public int[] TagIds { get; set; }

        /// <summary>
        /// A list of tag names this image contains.
        /// </summary>
        [JsonPropertyName("tags")]
        public string[] Tags { get; set; }

        /// <summary>
        /// Whether this image has finished thumbnail generation. Do not attempt to load images from view_url or representations if this is false.
        /// </summary>
        [JsonPropertyName("thumbnails_generated")]
        public bool HasGeneratedThumbnails { get; set; }

        /// <summary>
        /// The time, in UTC, the image was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The image's uploader.
        /// </summary>
        [JsonPropertyName("uploader")]
        public string Uploader { get; set; }

        /// <summary>
        /// The ID of the image's uploader.
        /// </summary>
        [JsonPropertyName("uploader_id")]
        public int? UploaderId { get; set; }

        /// <summary>
        /// The image's number of upvotes.
        /// </summary>
        [JsonPropertyName("upvotes")]
        public int UpvoteCount { get; set; }

        /// <summary>
        /// The image's view URL, including tags.
        /// </summary>
        [JsonPropertyName("view_url")]
        public string ViewUri { get; set; }

        /// <summary>
        /// The image's width, in pixels.
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// The lower bound of the Wilson score interval for the image, based on its upvotes and downvotes, given a z-score corresponding to a confidence of 99.5%.
        /// </summary>
        [JsonPropertyName("wilson_score")]
        public double WilsonScore { get; set; }
    }
}
