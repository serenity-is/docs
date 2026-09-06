# BaseSaveDeleteBehaviorAsync class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for behaviors implementing save and delete async behavior interfaces

```csharp
public abstract class BaseSaveDeleteBehaviorAsync : BaseSaveBehaviorAsync, IDeleteBehaviorAsync, 
    IDeleteExceptionBehavior
```

## Public Members

| name | description |
| --- | --- |
| virtual [OnAfterDeleteAsync](BaseSaveDeleteBehaviorAsync/OnAfterDeleteAsync.md)(…) |  |
| virtual [OnAuditAsync](BaseSaveDeleteBehaviorAsync/OnAuditAsync.md)(…) |  |
| virtual [OnBeforeDeleteAsync](BaseSaveDeleteBehaviorAsync/OnBeforeDeleteAsync.md)(…) |  |
| virtual [OnException](BaseSaveDeleteBehaviorAsync/OnException.md)(…) |  |
| virtual [OnPrepareQueryAsync](BaseSaveDeleteBehaviorAsync/OnPrepareQueryAsync.md)(…) |  |
| virtual [OnReturnAsync](BaseSaveDeleteBehaviorAsync/OnReturnAsync.md)(…) |  |
| virtual [OnValidateRequestAsync](BaseSaveDeleteBehaviorAsync/OnValidateRequestAsync.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseSaveDeleteBehaviorAsync](BaseSaveDeleteBehaviorAsync/BaseSaveDeleteBehaviorAsync.md)() | The default constructor. |

## See Also

* class [BaseSaveBehaviorAsync](./BaseSaveBehaviorAsync.md)
* interface [IDeleteBehaviorAsync](./IDeleteBehaviorAsync.md)
* interface [IDeleteExceptionBehavior](./IDeleteExceptionBehavior.md)
* **Source:** *[BaseSaveDeleteBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/62e26a99abba7fd00c7409a1334581e3c5ccd1f4/src/services/RequestHandlers/Save/BaseSaveDeleteBehaviorAsync.cs)*