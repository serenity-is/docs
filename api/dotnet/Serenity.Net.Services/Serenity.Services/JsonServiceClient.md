# JsonServiceClient class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A JSON service client implementation

```csharp
public class JsonServiceClient
```

## Public Members

| name | description |
| --- | --- |
| [JsonServiceClient](JsonServiceClient/JsonServiceClient.md)(…) | Creates an instance of JsonServiceClient for the passed baseUrl |
| virtual [Post&lt;TResponse&gt;](JsonServiceClient/Post.md)(…) | Post to JSON service |

## Protected Members

| name | description |
| --- | --- |
| [BaseUrl](JsonServiceClient/BaseUrl.md) { get; set; } | Base url for the client |
| [cookies-](JsonServiceClient/cookies-.md) | Cookie container |
| [InternalPost&lt;TResponse&gt;](JsonServiceClient/InternalPost.md)(…) | Posts to a JSON service, internal version |

## See Also

* **Source:** *[JsonServiceClient.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Json/JsonServiceClient.cs)*