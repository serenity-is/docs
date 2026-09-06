# BaseDeleteBehaviorAsync class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for types implementing [`IDeleteBehaviorAsync`](IDeleteBehaviorAsync.md)

```csharp
public abstract class BaseDeleteBehaviorAsync : IDeleteBehaviorAsync, IDeleteExceptionBehavior
```

## Public Members

| name | description |
| --- | --- |
| virtual [OnAfterDeleteAsync](BaseDeleteBehaviorAsync/OnAfterDeleteAsync.md)(…) |  |
| virtual [OnAuditAsync](BaseDeleteBehaviorAsync/OnAuditAsync.md)(…) |  |
| virtual [OnBeforeDeleteAsync](BaseDeleteBehaviorAsync/OnBeforeDeleteAsync.md)(…) |  |
| virtual [OnException](BaseDeleteBehaviorAsync/OnException.md)(…) |  |
| virtual [OnPrepareQueryAsync](BaseDeleteBehaviorAsync/OnPrepareQueryAsync.md)(…) |  |
| virtual [OnReturnAsync](BaseDeleteBehaviorAsync/OnReturnAsync.md)(…) |  |
| virtual [OnValidateRequestAsync](BaseDeleteBehaviorAsync/OnValidateRequestAsync.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseDeleteBehaviorAsync](BaseDeleteBehaviorAsync/BaseDeleteBehaviorAsync.md)() | The default constructor. |

## See Also

* interface [IDeleteBehaviorAsync](IDeleteBehaviorAsync.md)
* interface [IDeleteExceptionBehavior](IDeleteExceptionBehavior.md)
* **Source:** *[BaseDeleteBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/62e26a99abba7fd00c7409a1334581e3c5ccd1f4/src/services/RequestHandlers/Delete/BaseDeleteBehaviorAsync.cs)*