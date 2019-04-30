using Newtonsoft.Json;

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
        [JsonProperty("top_scoring")]
        public ImageJson[] TopScoring { get; set; }
        [JsonProperty("top_commented")]
        public ImageJson[] TopCommented { get; set; }
        [JsonProperty("all_time_top_scoring")]
        public ImageJson[] AllTimeTopScoring { get; set; }
        public InteractionJson[] Interactions { get; set; }
    }

    public class SearchRoot
    {
        public ImageJson[] Search { get; set; }
        public int Total { get; set; }
        public InteractionJson[] Interactions { get; set; }
    }
}
