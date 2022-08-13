using System;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels;

public class PostJson
{
    /// <summary>
    /// The post's ID.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// The post's author.
    /// </summary>
    [JsonPropertyName("author")]
    public string Author { get; set; }

    /// <summary>
    /// The URL of the author's avatar. May be a link to the CDN path, or a data: URI.
    /// </summary>
    [JsonPropertyName("avatar")]
    public string AvatarUri { get; set; }

    /// <summary>
    /// The post text.
    /// </summary>
    [JsonPropertyName("body")]
    public string Body { get; set; }

    /// <summary>
    /// The creation time, in UTC, of the comment.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The edit reason for this comment, or null if none provided.
    /// </summary>
    [JsonPropertyName("edit_reason")]
    public string EditReason { get; set; }

    /// <summary>
    /// The time, in UTC, this comment was last edited at, or null if it was not edited.
    /// </summary>
    [JsonPropertyName("edited_at")]
    public DateTime? EditedAt { get; set; }

    /// <summary>
    /// The ID of the topic the post belongs to.
    /// </summary>
    [JsonPropertyName("topic_id")]
    public int? TopicId { get; set; }

    /// <summary>
    /// The time, in UTC, the comment was last updated at.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// The ID of the user the comment belongs to, if any.
    /// </summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }
}
