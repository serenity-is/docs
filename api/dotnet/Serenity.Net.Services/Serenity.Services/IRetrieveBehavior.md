# IRetrieveBehavior interface
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Marker interface for retrieve behaviors that can be used as a mixin within a RetrieveRequestHandler lifecycle.

```csharp
public interface IRetrieveBehavior
```

## Remarks

All retrieve behaviors should implement either [`IRetrieveBehaviorSync`](./IRetrieveBehaviorSync.md) or [`IRetrieveBehaviorAsync`](./IRetrieveBehaviorAsync.md), not this interface directly.

## See Also

* **Source:** *[IRetrieveBehavior.cs](https://github.com/serenity-is/Serenity/blob/aa5433b74475d7a249a3550344ee8ccea8e5a8eb/src/services/RequestHandlers/Retrieve/IRetrieveBehavior.cs)*