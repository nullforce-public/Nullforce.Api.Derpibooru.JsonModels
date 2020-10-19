using System;
using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class AwardsJson
    {
        /// <summary>
        /// The ID of the badge this award is derived from.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// The time, in UTC, when this award was given.
        /// </summary>
        [JsonPropertyName("awarded_on")]
        public DateTime AwardedOn { get; set; }

        /// <summary>
        /// The URL of this award.
        /// </summary>
        [JsonPropertyName("image_url")]
        public string ImageUri { get; set; }

        /// <summary>
        /// The label of this award.
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// The title of this award.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
