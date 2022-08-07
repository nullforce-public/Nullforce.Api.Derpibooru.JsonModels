using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class CommentRootJson
    {
        [JsonPropertyName("comment")]
        public CommentJson Comment { get; set; }
    }

    public class FiltersRootJson
    {
        [JsonPropertyName("filters")]
        public FilterJson[] Filters { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

    public class ForumsRootJson
    {
        [JsonPropertyName("forums")]
        public ForumJson[] Forums { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

    public class GallerySearchRoot
    {
        [JsonPropertyName("galleries")]
        public GalleryJson[] Galleries { get; set; }
    }

    public class ImageRootJson
    {
        [JsonPropertyName("image")]
        public ImageJson Image { get; set; }
    }

    public class ImageSearchRootJson
    {
        [JsonPropertyName("images")]
        public ImageJson[] Images { get; set; }
        [JsonPropertyName("interactions")]
        public InteractionJson[] Interactions { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; }
    }

    public class PostSearchRootJson
    {
        [JsonPropertyName("posts")]
        public PostJson[] Posts { get; set; }
    }

    public class ProfileRootJson
    {
        [JsonPropertyName("user")]
        public UserJson User { get; set; }
    }

    public class TagSearchRootJson
    {
        [JsonPropertyName("tags")]
        public TagJson[] Tags { get; set; }
    }

    public class TopicRootJson
    {
        [JsonPropertyName("topics")]
        public TopicJson[] Topics { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
