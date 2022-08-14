using System;

namespace Nullforce.Api.JsonModels.Twibooru.Tests.Integration;

public class TwibooruTests
{
    private readonly string _baseUri = "https://twibooru.org/api/v3";

    public TwibooruTests()
    {
        // Do this in Startup. All calls to the _baseUri will use the same HttpClient instance.
        FlurlHttp.ConfigureClient(_baseUri, cli => cli
            .WithHeaders(new
            {
                Accept = "application/json",
                User_Agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.75 Safari/537.36"
            }));
    }

    [Fact]
    public async void PostRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://twibooru.org/api/v3/posts/1
        var uri = _baseUri.AppendPathSegment("/posts/1");
        PostResponseJson root = null;
        PostJson post = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            root = JsonSerializer.Deserialize<PostResponseJson>(json);
            post = root.Post;
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        root.Should().NotBeNull();
        root.JsonExtensionData.Should().BeNull();

        // Property validation
        post.JsonExtensionData.Should().BeNull();

        post.Intensities.JsonExtensionData.Should().BeNull();

        post.Representations.JsonExtensionData.Should().BeNull();
    }

    [Fact]
    public async void FeaturedPostRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://twibooru.org/api/v3/posts/featured
        var uri = _baseUri.AppendPathSegment("/posts/featured");
        PostResponseJson root = null;
        PostJson post = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            root = JsonSerializer.Deserialize<PostResponseJson>(json);
            post = root.Post;
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        root.Should().NotBeNull();
        root.JsonExtensionData.Should().BeNull();

        // Property validation
        post.JsonExtensionData.Should().BeNull();

        post.Intensities.JsonExtensionData.Should().BeNull();

        post.Locations[0].JsonExtensionData.Should().BeNull();

        post.Representations.JsonExtensionData.Should().BeNull();
    }

    [Fact]
    public async void PostCommentsRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://twibooru.org/api/v3/posts/1/comments
        var uri = _baseUri.AppendPathSegment("/posts/1/comments");
        CommentResponseJson root = null;
        CommentJson[] comments = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            root = JsonSerializer.Deserialize<CommentResponseJson>(json);
            comments = root.Comments;
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        root.Should().NotBeNull();
        root.JsonExtensionData.Should().BeNull();

        // Property validation
        comments[0].JsonExtensionData.Should().BeNull();
    }

    [Fact]
    public async void SearchPostsRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://twibooru.org/api/v3/search/posts?q=safe
        var uri = _baseUri.AppendPathSegment("/search/posts");
        uri.SetQueryParam("q", "safe");
        SearchPostsResponseJson root = null;
        PostJson[] posts = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            root = JsonSerializer.Deserialize<SearchPostsResponseJson>(json);
            posts = root.Posts;
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        root.Should().NotBeNull();
        root.JsonExtensionData.Should().BeNull();

        // Property validation
        posts[0].JsonExtensionData.Should().BeNull();
    }

    [Fact]
    public async void SearchTagsRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://twibooru.org/api/v3/search/tags?q=fluttershy
        var uri = _baseUri.AppendPathSegment("/search/tags");
        uri.SetQueryParam("q", "fluttershy");
        SearchTagsResponseJson root = null;
        TagJson[] tags = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            root = JsonSerializer.Deserialize<SearchTagsResponseJson>(json);
            tags = root.Tags;
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        root.Should().NotBeNull();
        root.JsonExtensionData.Should().BeNull();

        // Property validation
        tags[0].JsonExtensionData.Should().BeNull();
    }
}
