using System;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
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
        /// The post text.
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// The ID of the topic the post belongs to.
        /// </summary>
        [JsonPropertyName("topic_id")]
        public int? TopicId { get; set; }

        /// <summary>
        /// The ID of the user the comment belongs to, if any.
        /// </summary>
        [JsonPropertyName("user_id")]
        public int? UserId { get; set; }
    }
}
