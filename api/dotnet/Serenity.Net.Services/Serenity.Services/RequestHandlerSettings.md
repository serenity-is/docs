# RequestHandlerSettings class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains settings that are applied to request handlers. Bound from the `RequestHandlerSettings` section in appsettings.json when available.

```csharp
public class RequestHandlerSettings : IOptions<RequestHandlerSettings>
```

## Public Members

| name | description |
| --- | --- |
| [RequestHandlerSettings](RequestHandlerSettings/RequestHandlerSettings.md)() | The default constructor. |
| static readonly [Default](RequestHandlerSettings/Default.md) | Gets the default settings (no limits). |
| [DefaultPageSize](RequestHandlerSettings/DefaultPageSize.md) { get; set; } | Gets or sets the default page size (take) applied when a List request does not specify one (e.g. take is zero). Zero means no default, so all records may be returned. |
| [ExcludeTotalCountByDefault](RequestHandlerSettings/ExcludeTotalCountByDefault.md) { get; set; } | Gets or sets whether the total record count is excluded by default for list requests that do not explicitly specify [`ExcludeTotalCount`](./ListRequest/ExcludeTotalCount.md) (i.e. it is `null` / not sent). Default is false, which preserves the historical behavior of calculating the total (and issuing a `COUNT(*)`) for paged requests. When a request has a zero take that [`DefaultPageSize`](./RequestHandlerSettings/DefaultPageSize.md) / [`MaxPageSize`](./RequestHandlerSettings/MaxPageSize.md) turns into an actual page size, the total is still returned as if [`ExcludeTotalCount`](./ListRequest/ExcludeTotalCount.md) was false, unless [`IncludeMore`](./ListRequest/IncludeMore.md) was requested (a More indicator is returned instead). |
| [MaxPageSize](RequestHandlerSettings/MaxPageSize.md) { get; set; } | Gets or sets the maximum page size (take) allowed for List requests. When greater than zero, a requested page size larger than this is clamped to this value, and an unspecified page size is also limited to this value. The response returns the applied take. Zero means no limit. |
| [Value](RequestHandlerSettings/Value.md) { get; } | Gets this instance. |
| [With](RequestHandlerSettings/With.md)(…) | Creates a copy of these settings with the specified changes applied, without modifying this instance. Useful for returning different settings per request / entity, e.g. a limited page size for public access and unlimited for administrators. |
| const [SectionKey](RequestHandlerSettings/SectionKey.md) | The default section key in appsettings.json |

## See Also

* **Source:** *[RequestHandlerSettings.cs](https://github.com/serenity-is/Serenity/blob/672c3a9116183bcea311db48e4da2bc19688f626/src/services/RequestHandlers/Handler/RequestHandlerSettings.cs)*