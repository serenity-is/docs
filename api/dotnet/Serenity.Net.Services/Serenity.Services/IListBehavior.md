# IListBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marker interface for list behaviors that can be used as a mixin within a ListRequestHandler lifecycle.

```csharp
public interface IListBehavior
```

## Remarks

All list behaviors should implement either [`IListBehaviorSync`](./IListBehaviorSync.md) or [`IListBehaviorAsync`](./IListBehaviorAsync.md), not this interface directly.

## See Also

* **Source:** *[IListBehavior.cs](https://github.com/serenity-is/Serenity/blob/6b0ee5bf7cf3317b3c89e88bd6a74f4e510d83c6/src/services/RequestHandlers/List/IListBehavior.cs)*