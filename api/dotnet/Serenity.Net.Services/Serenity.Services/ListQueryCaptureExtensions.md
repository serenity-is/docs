# ListQueryCaptureExtensions class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extensions to find the query capture capability of list handlers.

```csharp
public static class ListQueryCaptureExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [GetPostQueryOverrides](ListQueryCaptureExtensions/GetPostQueryOverrides.md)(…) | Gets the names of the methods of a list handler, looking through the sync / async wrappers, that run after its query is executed and that the handler overrides, e.g. `ProcessEntity` or `OnReturn`. As they don't run when the query is captured, a filter they apply, e.g. by dropping rows, would not take effect, so a consumer may refuse to capture the query of such a handler unless told that it filters only in its query. It doesn't check the list behaviors of the handler. |
| static [GetQueryCapture](ListQueryCaptureExtensions/GetQueryCapture.md)(…) | Gets the query capture capability of a list handler, looking through the sync / async wrappers the handler factory may return, or null if the handler can't capture its query. A synchronous handler's capture is adapted to the async interface. |

## See Also

* **Source:** *[ListQueryCaptureExtensions.cs](https://github.com/serenity-is/Serenity/blob/c9de1423e8c163e87ed25856ef3b74517aea2c6c/src/services/RequestHandlers/List/ListQueryCaptureExtensions.cs)*