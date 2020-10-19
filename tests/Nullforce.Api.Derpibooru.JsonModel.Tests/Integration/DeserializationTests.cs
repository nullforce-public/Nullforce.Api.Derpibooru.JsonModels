using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FluentAssertions;
using Flurl;
using Flurl.Http;
using Xunit;

namespace Nullforce.Api.Derpibooru.JsonModels.Tests.Integration
{
    public class DeserializationTests
    {
        private readonly string _baseUri = "https://derpibooru.org/api/v1/json";

        public DeserializationTests()
        {
            // Do this in Startup. All calls to SimpleCast will use the same HttpClient instance.
            FlurlHttp.ConfigureClient(_baseUri, cli => cli
                .WithHeaders(new
                {
                    Accept = "application/json",
                    User_Agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.75 Safari/537.36" // Flurl will convert that underscore to a hyphen
                }));
        }

        [Fact]
        public void CommentRoot_GetJson_SuccessWithoutExceptions()
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

            act.Should().NotThrow();
            commentRoot.Should().NotBeNull();

            // Property validation
            comment.Id.Should().Be(7093003);
            comment.Author.Should().Be("genervt");
            comment.Avatar.Should().Be("https://derpicdn.net/avatars/2018/2/20/121207d4a04abfd859d5a09.png");
            comment.Body.Should().Be("Adorable Fluttershy making cute noises.");
            comment.CreatedAt.Should().Be(DateTime.Parse("2018-04-27T19:40:27"));
            comment.EditReason.Should().BeNullOrEmpty();
            comment.EditedAt.Should().BeNull();
            comment.ImageId.Should().Be(1384692);
            comment.UpdatedAt.Should().Be(DateTime.Parse("2018-04-27T19:40:27"));
            comment.UserId.Should().Be(434362);
        }

        [Fact]
        public void GallerySearchRoot_GetJson_SuccessWithoutExceptions()
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

            act.Should().NotThrow();
            gallerySearchRoot.Should().NotBeNull();

            // Property validation
            gallery.Description.Should().Be("Favorites");
            gallery.Id.Should().Be(11972);
            gallery.SpoilerWarning.Should().BeEmpty();
            gallery.ThumbnailId.Should().Be(1426222);
            gallery.Title.Should().Be("Fluttershy");
            gallery.User.Should().Be("Zippi");
            gallery.UserId.Should().Be(500995);
        }

        [Fact]
        public void ImageRoot_GetJson_SuccessWithoutExceptions()
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

            act.Should().NotThrow();
            imageRoot.Should().NotBeNull();

            // Property validation
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
            image.Format.Should().Be("PNG");
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
            image.UpdatedAt.Should().Be(DateTime.Parse("2020-07-02 11:33:07"));
            image.Uploader.Should().BeNull();
            image.UploaderId.Should().BeNull();
            image.UpvoteCount.Should().Be(image.Score + image.DownvoteCount);
            image.ViewUri.Should().Be("https://derpicdn.net/img/view/2017/3/11/1384692__safe_artist-colon-yakovlev-dash-vad_fluttershy_pegasus_pony_-colon-3_-colon-t_bed_behaving+like+a+cat_box_cheek+fluff_chest+fluff_colored+sketch_cute_d.png");
            image.Width.Should().Be(1400);
            image.WilsonScore.Should().BeGreaterThan(0);

            image.Intensities.Should().NotBeNull();
            image.Intensities.NE.Should().BeGreaterThan(0);
            image.Intensities.NW.Should().BeGreaterThan(0);
            image.Intensities.SE.Should().BeGreaterThan(0);
            image.Intensities.SW.Should().BeGreaterThan(0);

            image.Representations.Should().NotBeNull();
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
        public void Oembed_GetJson_SuccessWithoutExceptions()
        {
            // https://derpibooru.org/api/v1/json/oembed?url=https://derpicdn.net/img/view/2017/3/11/1384692.png
            var uri = _baseUri.AppendPathSegment("/oembed").SetQueryParam("url", "https://derpicdn.net/img/view/2017/3/11/1384692.png");
            OembedJson oembed = null;

            Func<Task> act = async () =>
            {
                var json = await uri.GetStringAsync();
                oembed = JsonSerializer.Deserialize<OembedJson>(json);
            };

            act.Should().NotThrow();
            oembed.Should().NotBeNull();

            // Property validation
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
        public void PostsSearchRoot_GetJson_SuccessWithoutExceptions()
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

            act.Should().NotThrow();
            postsRoot.Should().NotBeNull();

            // Property validation
            post.Author.Should().Be("Havock");
            post.Body.Should().Contain("None can resist her cuteness.");
            post.Id.Should().Be(4236623);
            post.UserId.Should().Be(325550);
        }

        [Fact]
        public void TagSearchRoot_GetJson_SuccessWithoutExceptions()
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

            act.Should().NotThrow();
            tagsRoot.Should().NotBeNull();

            // Property validation
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
}
