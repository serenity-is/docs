# IHttpContextItemsAccessor interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Provides access to the per-request item dictionary, typically backed by `HttpContext.Items` for web requests.

```csharp
public interface IHttpContextItemsAccessor
```

## Members

| name | description |
| --- | --- |
| [Items](IHttpContextItemsAccessor/Items.md) { get; } | Gets the dictionary that can be used as request-scoped storage. |

## Remarks

Returns `null` when accessed outside of a web request context.

## See Also

* **Source:** *[IHttpContextItemsAccessor.cs](https://github.com/serenity-is/Serenity/blob/eef6be1d7741640aed4ce405c3b44984620b84be/src/core/Authorization/IHttpContextItemsAccessor.cs)*