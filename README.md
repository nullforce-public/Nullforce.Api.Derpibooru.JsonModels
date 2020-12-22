# Nullforce.Api.Derpibooru.JsonModels

A C# wrapper for Derpibooru JSON models

|||
----------------------|---
**Build**             | ![Build Status](https://github.com/nullforce-public/Nullforce.Api.Derpibooru.JsonModels/workflows/Nullforce.Api.Derpibooru.JsonModels%20Build/badge.svg?branch=main)
**NuGet**             | [![nuget](https://img.shields.io/nuget/v/Nullforce.Api.Derpibooru.JsonModels.svg)](https://www.nuget.org/packages/Nullforce.Api.Derpibooru.JsonModels/)
**NuGet (prerelease)**| [![nuget](https://img.shields.io/nuget/vpre/Nullforce.Api.Derpibooru.JsonModels.svg)](https://www.nuget.org/packages/Nullforce.Api.Derpibooru.JsonModels/)


## Usage Example

An example using [Flurl.Http](https://flurl.dev/):

Install the `Nullforce.Api.Derpibooru.JsonModels` package from NuGet (allow prerelease as needed).

```csharp
using Flurl;
using Flurl.Http;
using Nullforce.Api.Derpibooru.JsonModels;

...

var uri = "https://derpibooru.org/search.json";
uri = uri.SetQueryParam("q", "fluttershy");

var searchResult = await uri.GetJsonAsync<SearchRootJson>();
```

## See Also

If you're looking for a Derpibooru client written in C# that uses these models,
see [Nullforce.Api.Derpibooru](https://github.com/nullforce-public/Nullforce.Api.Derpibooru)
