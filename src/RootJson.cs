using System.Text.Json.Serialization;

namespace Nullforce.Api.Derpibooru.JsonModels
{
    public class CommentRootJson
    {
        [JsonPropertyName("comment")]
        public CommentJson Comment { get; set; }
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

    public class TagSearchRootJson
    {
        [JsonPropertyName("tags")]
        public TagJson[] Tags { get; set; }
    }
}
