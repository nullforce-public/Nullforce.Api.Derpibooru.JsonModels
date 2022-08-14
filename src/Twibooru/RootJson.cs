namespace Nullforce.Api.JsonModels.Twibooru;


public class CommentResponseJson : JsonBase
{
    [JsonPropertyName("comments")]
    public CommentJson[] Comments { get; set; }
}

public class PostResponseJson : JsonBase
{
    [JsonPropertyName("post")]
    public PostJson Post { get; set; }
}

public class SearchPostsResponseJson : JsonBase
{
    [JsonPropertyName("posts")]
    public PostJson[] Posts { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}

public class SearchTagsResponseJson : JsonBase
{
    [JsonPropertyName("tags")]
    public TagJson[] Tags { get; set; }
}
