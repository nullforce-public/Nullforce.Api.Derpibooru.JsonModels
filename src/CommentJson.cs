using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class CommentJson
    {
        /// <summary>
        /// The comment's ID.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The comment's author.
        /// </summary>
        [JsonPropertyName("author")]
        public string Author { get; set; }

        /// <summary>
        /// The comment text.
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// The ID of the image the comment belongs to.
        /// </summary>
        [JsonPropertyName("image_id")]
        public int ImageId { get; set; }

        /// <summary>
        /// The ID of the user the comment belongs to, if any.
        /// </summary>
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }
    }
}
