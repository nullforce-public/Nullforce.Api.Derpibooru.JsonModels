using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    /// <summary>
    /// The interactions of the user specified by the API key given.
    /// Known interation types:
    ///   - faved: null
    ///   - voted: up, down
    /// </summary>
    public class InteractionJson
    {
        public int Id { get; set; }
        [JsonPropertyName("interaction_type")]
        public string InteractionType { get; set; }
        public string Value { get; set; }
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }
        [JsonPropertyName("image_id")]
        public int ImageId { get; set; }
    }
}
