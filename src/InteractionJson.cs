using Newtonsoft.Json;

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
        [JsonProperty("interaction_type")]
        public string InteractionType { get; set; }
        public string Value { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("image_id")]
        public int ImageId { get; set; }
    }
}
