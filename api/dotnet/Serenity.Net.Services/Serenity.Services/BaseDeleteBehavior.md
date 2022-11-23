# BaseDeleteBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for types implementing [`IDeleteBehavior`](IDeleteBehavior.md)

```csharp
public abstract class BaseDeleteBehavior : IDeleteBehavior, IDeleteExceptionBehavior
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

* interface [IDeleteBehavior](IDeleteBehavior.md)
* interface [IDeleteExceptionBehavior](IDeleteExceptionBehavior.md)
* **Source:** *[BaseDeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Delete/BaseDeleteBehavior.cs)*