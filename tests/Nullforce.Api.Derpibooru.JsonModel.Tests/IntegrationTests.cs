using System;
using System.Threading.Tasks;
using FluentAssertions;
using Flurl;
using Flurl.Http;
using Nullforce.Api.Derpibooru.JsonModels;
using Xunit;

namespace Nullforce.Api.Derpibooru.JsonModel.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ImagesRoot_GetJson_SuccessWithoutExceptions()
        {
            var uri = "https://derpibooru.org/images.json";
            ImagesRootJson imagesResult = null;

            Func<Task> act = async () =>
            {
                imagesResult = await uri.GetJsonAsync<ImagesRootJson>();
            };

            act.Should().NotThrow();
            imagesResult.Should().NotBeNull();
        }

        [Fact]
        public void ListsRoot_GetJson_SuccessWithoutExceptions()
        {
            var uri = "https://derpibooru.org/lists.json";
            ListsRootJson listsResult = null;

            Func<Task> act = async () =>
            {
                listsResult = await uri.GetJsonAsync<ListsRootJson>();
            };

            act.Should().NotThrow();
            listsResult.Should().NotBeNull();
        }

        [Fact]
        public void SearchRoot_GetJson_SuccessWithoutExceptions()
        {
            var uri = "https://derpibooru.org/search.json";
            uri = uri.SetQueryParam("q", "fluttershy");
            SearchRootJson searchResult = null;

            Func<Task> act = async () =>
            {
                searchResult = await uri.GetJsonAsync<SearchRootJson>();
            };

            act.Should().NotThrow();
            searchResult.Should().NotBeNull();
        }
    }
}
