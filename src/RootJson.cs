namespace Nullforce.Api.Derpibooru.JsonModels;

public class CommentRootJson : JsonBase
{
    [JsonPropertyName("comment")]
    public CommentJson Comment { get; set; }
}

public class FiltersRootJson : JsonBase
{
    [JsonPropertyName("filters")]
    public FilterJson[] Filters { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class ForumsRootJson : JsonBase
{
    [JsonPropertyName("forums")]
    public ForumJson[] Forums { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class GallerySearchRoot : JsonBase
{
    [JsonPropertyName("galleries")]
    public GalleryJson[] Galleries { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class ImageRootJson : JsonBase
{
    [JsonPropertyName("image")]
    public ImageJson Image { get; set; }

    [JsonPropertyName("interactions")]
    public InteractionJson[] Interactions { get; set; }
}

public class ImageSearchRootJson : JsonBase
{
    [JsonPropertyName("images")]
    public ImageJson[] Images { get; set; }

    [JsonPropertyName("interactions")]
    public InteractionJson[] Interactions { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class PostSearchRootJson : JsonBase
{
    [JsonPropertyName("posts")]
    public PostJson[] Posts { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class ProfileRootJson : JsonBase
{
    [JsonPropertyName("user")]
    public UserJson User { get; set; }
}

public class TagSearchRootJson : JsonBase
{
    [JsonPropertyName("tags")]
    public TagJson[] Tags { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class TopicRootJson : JsonBase
{
    [JsonPropertyName("topics")]
    public TopicJson[] Topics { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}
