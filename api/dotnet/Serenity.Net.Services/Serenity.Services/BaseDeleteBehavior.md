# BaseDeleteBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for types implementing [`IDeleteBehaviorSync`](IDeleteBehaviorSync.md)

```csharp
public abstract class BaseDeleteBehavior : IDeleteBehaviorSync, IDeleteExceptionBehavior
```

## Public Members

| name | description |
| --- | --- |
| virtual [OnAfterDelete](BaseDeleteBehavior/OnAfterDelete.md)(…) |  |
| virtual [OnAudit](BaseDeleteBehavior/OnAudit.md)(…) |  |
| virtual [OnBeforeDelete](BaseDeleteBehavior/OnBeforeDelete.md)(…) |  |
| virtual [OnException](BaseDeleteBehavior/OnException.md)(…) |  |
| virtual [OnPrepareQuery](BaseDeleteBehavior/OnPrepareQuery.md)(…) |  |
| virtual [OnReturn](BaseDeleteBehavior/OnReturn.md)(…) |  |
| virtual [OnValidateRequest](BaseDeleteBehavior/OnValidateRequest.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseDeleteBehavior](BaseDeleteBehavior/BaseDeleteBehavior.md)() | The default constructor. |

## See Also

* interface [IDeleteBehaviorSync](IDeleteBehaviorSync.md)
* interface [IDeleteExceptionBehavior](IDeleteExceptionBehavior.md)
* **Source:** *[BaseDeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/d867db7e483c51f5b1e62c31118c3b729fc6b78f/src/services/RequestHandlers/Delete/BaseDeleteBehavior.cs)*