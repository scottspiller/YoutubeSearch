# YoutubeSearch
YoutubeSearch is a library for .NET, written in C#, to show search query results from YouTube.

# Target platforms
- .NET Standard 2.0

# NuGet
**https://www.nuget.org/packages/YoutubeSearch.NETSTANDARD/**

# License
YoutubeSearch is licensed under the **MIT** license.

# Example code
```c#
// Keyword
string querystring = "test";

// Number of result pages
int querypages = 1;

// Offset value for querypages
int querypagesOffset = 2;

var items = new VideoSearch();

foreach (var item in items.SearchQuery(querystring, querypages))
{
    Console.WriteLine(item.Title);
}

//For asynchronous execution use:
var result = await items.SearchQueryAsync(querystring, querypages);

//This will query from page 3 to 4
var offsetResult = items.SearchQuery(querystring, querypages, querypagesOffset);
```

# Supported Items

- Title
- Author
- Description
- Duration
- Thumbnail
- Video Url


