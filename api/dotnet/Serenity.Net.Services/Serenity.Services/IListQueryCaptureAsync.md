# IListQueryCaptureAsync interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Implemented by async list handlers that can build the query they would execute for a request without executing it, to use it as a source of another query. Use [`GetQueryCapture`](./ListQueryCaptureExtensions/GetQueryCapture.md) to find this capability through a list request processor, which may be a sync / async wrapper.

```csharp
public interface IListQueryCaptureAsync
```

## Members

| name | description |
| --- | --- |
| [CaptureQueryAsync](IListQueryCaptureAsync/CaptureQueryAsync.md)(…) | Builds the query the handler would execute for the request, without executing it. See [`CaptureQueryAsync`](./ListRequestHandlerAsync-3/CaptureQueryAsync.md). |

## See Also

* **Source:** *[IListQueryCaptureAsync.cs](https://github.com/serenity-is/Serenity/blob/b3c765b20f614dece5c03fda762d4326d17823d2/src/services/RequestHandlers/List/IListQueryCaptureAsync.cs)*