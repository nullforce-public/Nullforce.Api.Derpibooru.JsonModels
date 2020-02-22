using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class ImagesRootJson
    {
        public ImageJson[] Images { get; set; }
        // public int Total { get; set; }
        public InteractionJson[] Interactions { get; set; }
    }

    public class ListsRootJson
    {
        [JsonPropertyName("top_scoring")]
        public ImageJson[] TopScoring { get; set; }
        [JsonPropertyName("top_commented")]
        public ImageJson[] TopCommented { get; set; }
        [JsonPropertyName("all_time_top_scoring")]
        public ImageJson[] AllTimeTopScoring { get; set; }
        public InteractionJson[] Interactions { get; set; }
    }

    public class SearchRootJson
    {
        public ImageJson[] Search { get; set; }
        public int Total { get; set; }
        public InteractionJson[] Interactions { get; set; }
    }
}
