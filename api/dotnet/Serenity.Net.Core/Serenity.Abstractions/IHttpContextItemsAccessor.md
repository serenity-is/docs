# IHttpContextItemsAccessor interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Interface for abstraction that should return HttpContext.Current.Items for web requests, and null for normal threads.

```csharp
public interface IHttpContextItemsAccessor
```

## Members

| name | description |
| --- | --- |
| [Items](IHttpContextItemsAccessor/Items.md) { get; } | A dictionary that can be used as a request context specific storage |

## See Also

* **Source:** *[IHttpContextItemsAccessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/IHttpContextItemsAccessor.cs)*