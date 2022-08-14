using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Execution;
using Flurl;
using Flurl.Http;
using Xunit;

namespace Nullforce.Api.Derpibooru.JsonModels.Tests.Integration;

public class DeserializationTests
{
    private readonly string _baseUri = "https://derpibooru.org/api/v1/json";

    public DeserializationTests()
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
    public async void CommentRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://derpibooru.org/api/v1/json/comments/7093003
        var uri = _baseUri.AppendPathSegment("/comments/7093003");
        CommentRootJson commentRoot = null;
        CommentJson comment = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            commentRoot = JsonSerializer.Deserialize<CommentRootJson>(json);
            comment = commentRoot.Comment;
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        commentRoot.Should().NotBeNull();

        // Property validation
        comment.JsonExtensionData.Should().BeNull();
        comment.Id.Should().Be(7093003);
        comment.Author.Should().Be("genervt");
        comment.AvatarUri.Should().Be("https://derpicdn.net/avatars/2018/2/20/121207d4a04abfd859d5a09.png");
        comment.Body.Should().Be("Adorable Fluttershy making cute noises.");
        comment.CreatedAt.Should().Be(DateTime.Parse("2018-04-27T19:40:27"));
        comment.EditReason.Should().BeNullOrEmpty();
        comment.EditedAt.Should().BeNull();
        comment.ImageId.Should().Be(1384692);
        comment.UpdatedAt.Should().Be(DateTime.Parse("2018-04-27T19:40:27"));
        comment.UserId.Should().Be(434362);
    }

    [Fact]
    public async void GallerySearchRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://derpibooru.org/api/v1/json/search/galleries?q=title:fluttershy
        var uri = _baseUri.AppendPathSegment("/search/galleries").SetQueryParam("q", "id:11972");
        GallerySearchRoot gallerySearchRoot = null;
        GalleryJson gallery = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            gallerySearchRoot = JsonSerializer.Deserialize<GallerySearchRoot>(json);
            gallery = gallerySearchRoot.Galleries.First();
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        gallerySearchRoot.Should().NotBeNull();

        // Property validation
        gallery.JsonExtensionData.Should().BeNull();
        gallery.Description.Should().Be("Favorites");
        gallery.Id.Should().Be(11972);
        gallery.SpoilerWarning.Should().BeEmpty();
        gallery.ThumbnailId.Should().Be(1426222);
        gallery.Title.Should().Be("Fluttershy");
        gallery.User.Should().Be("Zippi");
        gallery.UserId.Should().Be(500995);
    }

    [Fact]
    public async void ImageRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://derpibooru.org/api/v1/json/images/1384692
        var uri = _baseUri.AppendPathSegment("/images/1384692");
        ImageRootJson imageRoot = null;
        ImageJson image = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            imageRoot = JsonSerializer.Deserialize<ImageRootJson>(json);
            image = imageRoot.Image;
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        imageRoot.Should().NotBeNull();

        // Property validation
        image.JsonExtensionData.Should().BeNull();
        image.AspectRatio.Should().BeApproximately(0.7588075880758808, 4);
        image.CommentCount.Should().BeGreaterOrEqualTo(32);
        image.CreatedAt.Should().Be(DateTime.Parse("2017-03-11T20:32:14"));
        image.DeletionReason.Should().BeNull();
        image.Description.Should().Be("Pony in box, inspired by my cat as usual X3 Just quick color sketch)");
        image.DownvoteCount.Should().BeGreaterOrEqualTo(6);
        image.DuplicateOf.Should().BeNull();
        image.Duration.Should().Be(0.04);
        image.FaveCount.Should().BeGreaterOrEqualTo(1408);
        image.FirstSeenAt.Should().Be(DateTime.Parse("2017-03-11T20:32:14"));
        image.Format.Should().Be("png");
        image.HasGeneratedThumbnails.Should().BeTrue();
        image.Height.Should().Be(1845);
        image.HiddenFromUsers.Should().BeFalse();
        image.Id.Should().Be(1384692);
        image.IsAnimated.Should().BeFalse();
        image.IsProcessed.Should().BeTrue();
        image.IsSpoilered.Should().BeFalse();
        image.MimeType.Should().Be("image/png");
        image.Name.Should().Be("favorite_place__color_sketch__by_yakovlev_vad-db1ybkb.png");
        image.OriginalSHA512Hash.Should().Be("a5b68e1cb435a818cc15d5a4e8f879d350700ae1dbe9d12b7d9e421abc6d2f6b622318d99d0e5b120c2c59b3df3b9b120e065a507142f48525935cbfd836588d");
        image.Score.Should().Be(image.UpvoteCount - image.DownvoteCount);
        image.SHA512Hash.Should().Be("a5b68e1cb435a818cc15d5a4e8f879d350700ae1dbe9d12b7d9e421abc6d2f6b622318d99d0e5b120c2c59b3df3b9b120e065a507142f48525935cbfd836588d");
        image.SourceUri.Should().Be("http://yakovlev-vad.deviantart.com/art/Favorite-place-Color-Sketch-668408843");
        image.TagCount.Should().Be(image.TagIds.Length);
        image.TagIds.Should().HaveCount(image.TagCount);
        image.Tags.Should().HaveCount(image.TagCount);
        image.UpdatedAt.Should().BeAfter(DateTime.Parse("2020-07-02 11:33:07"));
        image.Uploader.Should().BeNull();
        image.UploaderId.Should().BeNull();
        image.UpvoteCount.Should().Be(image.Score + image.DownvoteCount);
        image.ViewUri.Should().Match("https://derpicdn.net/img/view/2017/3/11/1384692__safe_artist-colon-yakovlev-dash-vad_fluttershy_*.png");
        image.Width.Should().Be(1400);
        image.WilsonScore.Should().BeGreaterThan(0);

        image.Intensities.Should().NotBeNull();
        image.Intensities.JsonExtensionData.Should().BeNull();
        image.Intensities.NE.Should().BeGreaterThan(0);
        image.Intensities.NW.Should().BeGreaterThan(0);
        image.Intensities.SE.Should().BeGreaterThan(0);
        image.Intensities.SW.Should().BeGreaterThan(0);

        image.Representations.Should().NotBeNull();
        image.Representations.JsonExtensionData.Should().BeNull();
        image.Representations.Full.Should().NotBeNullOrEmpty();
        image.Representations.Large.Should().NotBeNullOrEmpty();
        image.Representations.Medium.Should().NotBeNullOrEmpty();
        image.Representations.Small.Should().NotBeNullOrEmpty();
        image.Representations.Tall.Should().NotBeNullOrEmpty();
        image.Representations.Thumb.Should().NotBeNullOrEmpty();
        image.Representations.ThumbSmall.Should().NotBeNullOrEmpty();
        image.Representations.ThumbTiny.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async void Oembed_GetJson_SuccessWithoutExceptions()
    {
        // https://derpibooru.org/api/v1/json/oembed?url=https://derpicdn.net/img/view/2017/3/11/1384692.png
        var uri = _baseUri.AppendPathSegment("/oembed").SetQueryParam("url", "https://derpicdn.net/img/view/2017/3/11/1384692.png");
        OembedJson oembed = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            oembed = JsonSerializer.Deserialize<OembedJson>(json);
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        oembed.Should().NotBeNull();

        // Property validation
        oembed.JsonExtensionData.Should().BeNull();
        oembed.Author.Should().Be("yakovlev-vad");
        oembed.AuthorUri.Should().Be("http://yakovlev-vad.deviantart.com/art/Favorite-place-Color-Sketch-668408843");
        oembed.CacheAge.Should().Be(7200);
        oembed.DerpibooruCommentCount.Should().BeGreaterOrEqualTo(32);
        oembed.DerpibooruId.Should().Be(1384692);
        oembed.DerpibooruScore.Should().BeInRange(-9999, 9999);
        oembed.DerpibooruTags.Should().HaveCountGreaterThan(0);
        oembed.ProviderName.Should().Be("Derpibooru");
        oembed.ProviderUri.Should().Be("https://derpibooru.org");
        oembed.Title.Should().StartWith("#1384692");
        oembed.Type.Should().Be("photo");
        oembed.Version.Should().Be("1.0");
    }

    [Fact]
    public async void PostsSearchRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://derpibooru.org/api/v1/json/search/posts?q=id:4236623
        var uri = _baseUri.AppendPathSegment("/search/posts").SetQueryParam("q", "id:4236623");
        PostSearchRootJson postsRoot = null;
        PostJson post = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            postsRoot = JsonSerializer.Deserialize<PostSearchRootJson>(json);
            post = postsRoot.Posts.First();
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        postsRoot.Should().NotBeNull();

        // Property validation
        post.JsonExtensionData.Should().BeNull();
        post.Author.Should().Be("Havock");
        post.AvatarUri.Should().Be("data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxMjUiIGhlaWdodD0iMTI1IiB2aWV3Qm94PSIwIDAgMTI1IDEyNSIgY2xhc3M9ImF2YXRhci1zdmciPjxyZWN0IHdpZHRoPSIxMjUiIGhlaWdodD0iMTI1IiBmaWxsPSIjYzZkZmYyIi8+PHBhdGggZD0iTTE1LjQ1NiAxMDkuMTVDMTIuMDIgOTcuODA1IDYuNDQgOTUuMDM2LS43OTQgOTguODl2MTkuMTAyYzUuMTMtMTAuMDkgMTAuMjYzLTguMjk0IDE1LjM5NS01LjciIGZpbGw9IiM1Q0E1QUYiLz48cGF0aCBkPSJNNzMuMDU0IDI0LjQ2YzI1Ljg4NiAwIDM5LjE0NCAyNi4zOSAyOC45MTYgNDQuOTUgMS4yNjMuMzggNC45MjQgMi4yNzQgMy40MSA0LjgtMS41MTYgMi41MjUtNy41NzcgMTYuMjg4LTI3Ljc4IDE0Ljc3My0xLjAxIDYuNDQtLjMzIDEyLjYxMyAxLjY0MiAyMi44NTQgMS4zOSA3LjIyNC0uNjMyIDE0LjY0OC0uNjMyIDE0LjY0OHMtNDcuNzg1LjIxNi03My43NC0uMTI3Yy0xLjg4My02LjM4NyA4Ljk2NC0yNS43NiAyMC44MzMtMjQuNzQ4IDE1LjY3NCAxLjMzNCAxOS4xOTMgMS42NCAyMS41OTItMi4wMiAyLjQtMy42NjIgMC0yMy4yMzQtMy41MzUtMzAuODEtMy41MzYtNy41NzctNy44My00MC43ODUgMjkuMjk0LTQ0LjMyeiIgZmlsbD0iIzdBQUY0QyIvPjxwYXRoIGQ9Ik01Mi4xMDMgMjMuNDNDNzAuMTIgMS42NjggOTcuMTI2IDIuODkgMTEwLjE0IDE2Ljk5OGMyNy45MyAzMC4yNy0xNS42NzYgNDMuNjYyLTE4Ljk1MiAyMS44NjgtMTIuOTM0LTQuNDUzLTIzLjIyLTMuOTU2LTM0LjEzLTIuNzQ3TDUxLjEyIDQ5LjI2Yy41NTcgMjMuMjQgMTcuNzg3IDI2Ljg3NiAyMi44ODcgNDEuMzE1IDQuMTI0IDExLjY3Ny01LjMyNSAxNC4wNzUtOS40MDQgMTIuNjU2IDQuNjIyIDE3LjY2OC0xMi4wMjIgMjQuMy0yMC4wMDMgNy40LTEuNzk3LTMuOC0yLjgxLTE0LjgxMyAzLjY3Mi0xNC41MS0zLjE4Mi0xNi43ODQtMTcuNDUtMzguMjg1LTIuNDMtNjMuNzV6IiBmaWxsPSIjNUNBNUFGIi8+PHBhdGggZD0iTTY0LjM0MiAzNS41N3MzLjI4My04LjA4LTcuMzI0LTE5LjMxOGMtMS43NjgtMS43NjgtMy4wMy0yLjI3My00LjY3Mi0uNzU4LTEuNjQgMS41MTUtMTcuMDQ2IDE2LjAzNi4yNTMgMzguMjYuNTA0LTIuNCAxLjEzNS05LjU5NyAxLjEzNS05LjU5N3oiIGZpbGw9IiM3QUFGNEMiLz48L3N2Zz4=");
        post.Body.Should().Contain("None can resist her cuteness.");
        post.CreatedAt.Should().Be(DateTime.Parse("2019-02-24T16:58:07"));
        post.EditReason.Should().BeNullOrEmpty();
        post.EditedAt.Should().BeNull();
        post.Id.Should().Be(4236623);
        post.UpdatedAt.Should().Be(DateTime.Parse("2019-02-24T16:58:07"));
        post.UserId.Should().Be(325550);
    }

    [Fact]
    public async void ProfileRootJson_GetJson_SuccessWithoutExceptions()
    {
        // https://derpibooru.org/api/v1/json/profiles/216494
        var uri = _baseUri.AppendPathSegment("profiles/216494");
        ProfileRootJson profileRoot = null;
        UserJson user = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            profileRoot = JsonSerializer.Deserialize<ProfileRootJson>(json);
            user = profileRoot.User;
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        profileRoot.Should().NotBeNull();

        // Property validation
        user.JsonExtensionData.Should().BeNull();
        user.Name.Should().Be("Joey");
        user.PostCount.Should().BeGreaterOrEqualTo(4733);
        user.Role.Should().Be("user");
        user.Slug.Should().Be("Joey");
        user.TopicCount.Should().BeGreaterOrEqualTo(183);
        user.UploadCount.Should().BeGreaterOrEqualTo(732);

        user.Awards.Should().NotBeNull();
        user.Links.Should().NotBeNull();

        AwardsJson award = user.Awards.Where(a => a.Id == 25).FirstOrDefault();
        award.Should().NotBeNull();
        award.JsonExtensionData.Should().BeNull();
        award.Id.Should().Be(25);
        award.AwardedOn.Should().Be(DateTime.Parse("2019-10-26T07:45:30"));
        award.ImageUri.Should().Be("https://derpicdn.net/media/2016/10/3/135869b76b1b1cb145181e2.svg");
        award.Label.Should().Be("For users who have donated to the site");
        award.Title.Should().Be("Element of Generosity");

        LinksJson link = user.Links.FirstOrDefault();
        link.Should().NotBeNull();
        link.JsonExtensionData.Should().BeNull();
        link.CreatedAt.Should().Be(DateTime.Parse("2018-12-10T04:53:18"));
        link.State.Should().Be("verified");
        link.TagId.Should().Be(379649);
        link.UserId.Should().Be(216494);
    }

    [Fact]
    public async void TagSearchRoot_GetJson_SuccessWithoutExceptions()
    {
        // https://derpibooru.org/api/v1/json/search/tags?q=id:27724
        var uri = _baseUri.AppendPathSegment("/search/tags").SetQueryParam("q", "id:27724");
        TagSearchRootJson tagsRoot = null;
        TagJson tag = null;

        Func<Task> act = async () =>
        {
            var json = await uri.GetStringAsync();
            tagsRoot = JsonSerializer.Deserialize<TagSearchRootJson>(json);
            tag = tagsRoot.Tags.First();
        };

        using var _ = new AssertionScope();

        await act.Should().NotThrowAsync();
        tagsRoot.Should().NotBeNull();

        // Property validation
        tag.JsonExtensionData.Should().BeNull();
        tag.AliasedTag.Should().BeNull();
        tag.Aliases.Contains("fs");
        tag.Category.Should().Be("character");
        tag.Description.Should().Be("");
        tag.DoNotPostEntries.Should().BeEmpty();
        tag.Id.Should().Be(27724);
        tag.ImageCount.Should().BeGreaterOrEqualTo(191343);
        tag.ImpliedByTags.Should().NotBeEmpty();
        tag.ImpliedTags.Should().BeEmpty();
        tag.Name.Should().Be("fluttershy");
        tag.NameInNamespace.Should().Be("fluttershy");
        tag.Namespace.Should().BeNull();
        tag.ShortDescription.Should().Be("");
        tag.Slug.Should().Be("fluttershy");
        tag.SpoilerImageUri.Should().BeNull();
    }
}
