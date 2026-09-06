# IDeleteBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marker interface for delete behaviors that can be used as a mixin within a DeleteRequestHandler lifecycle.

```csharp
public interface IDeleteBehavior
```

## Remarks

All delete behaviors should implement either [`IDeleteBehaviorSync`](./IDeleteBehaviorSync.md) or [`IDeleteBehaviorAsync`](./IDeleteBehaviorAsync.md), not this interface directly.

## See Also

* **Source:** *[IDeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/IDeleteBehavior.cs)*