﻿namespace Nullforce.Api.JsonModels.Philomena;

public class LinksJson : JsonBase
{
    /// <summary>
    /// The creation time, in UTC, of this link.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// The state of this link.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }

    /// <summary>
    /// The ID of an associated tag for this link. null if no tag linked.
    /// </summary>
    [JsonPropertyName("tag_id")]
    public int? TagId { get; set; }

    /// <summary>
    /// The ID of the user who owns this link.
    /// </summary>
    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}
