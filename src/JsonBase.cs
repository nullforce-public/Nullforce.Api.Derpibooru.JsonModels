namespace Nullforce.Api.JsonModels;

public abstract class JsonBase
{
    [JsonExtensionData]
    public IDictionary<string, JsonElement> JsonExtensionData { get; set; }
}
