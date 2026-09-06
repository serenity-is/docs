# IUndeleteBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marker interface for undelete behaviors that can be used as a mixin within a UndeleteRequestHandler lifecycle.

```csharp
public interface IUndeleteBehavior
```

## Remarks

All undelete behaviors should implement either [`IUndeleteBehaviorSync`](./IUndeleteBehaviorSync.md) or [`IUndeleteBehaviorAsync`](./IUndeleteBehaviorAsync.md), not this interface directly.

## See Also

* **Source:** *[IUndeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/IUndeleteBehavior.cs)*