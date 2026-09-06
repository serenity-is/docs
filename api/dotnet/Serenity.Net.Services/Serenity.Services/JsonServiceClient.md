# JsonServiceClient class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A JSON service client implementation

```csharp
public class JsonServiceClient
```

| parameter | description |
| --- | --- |
| baseUrl | The base url |

## Public Members

| name | description |
| --- | --- |
| [JsonServiceClient](JsonServiceClient/JsonServiceClient.md)(…) | A JSON service client implementation |
| virtual [Post&lt;TResponse&gt;](JsonServiceClient/Post.md)(…) | Posts a request to a JSON service and returns the typed response. |

## Protected Members

| name | description |
| --- | --- |
| [BaseUrl](JsonServiceClient/BaseUrl.md) { get; set; } | Base url for the client |
| [cookies-](JsonServiceClient/cookies-.md) | Cookie container |
| [InternalPost&lt;TResponse&gt;](JsonServiceClient/InternalPost.md)(…) | Posts to a JSON service, internal version |

## Remarks

Creates an instance of JsonServiceClient for the passed baseUrl

## See Also

* **Source:** *[JsonServiceClient.cs](https://github.com/serenity-is/Serenity/blob/fa8ddd78cf707d00a1aca68d898e31e73d5971b9/src/services/Json/JsonServiceClient.cs)*