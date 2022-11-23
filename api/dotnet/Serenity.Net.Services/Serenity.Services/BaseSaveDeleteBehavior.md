# BaseSaveDeleteBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for behaviors implementing save and delete behavior interfaces

```csharp
public abstract class BaseSaveDeleteBehavior : BaseSaveBehavior, IDeleteBehavior, 
    IDeleteExceptionBehavior
```

## Public Members

| name | description |
| --- | --- |
| virtual [OnAfterDelete](BaseSaveDeleteBehavior/OnAfterDelete.md)(…) |  |
| virtual [OnAudit](BaseSaveDeleteBehavior/OnAudit.md)(…) |  |
| virtual [OnBeforeDelete](BaseSaveDeleteBehavior/OnBeforeDelete.md)(…) |  |
| virtual [OnException](BaseSaveDeleteBehavior/OnException.md)(…) |  |
| virtual [OnPrepareQuery](BaseSaveDeleteBehavior/OnPrepareQuery.md)(…) |  |
| virtual [OnReturn](BaseSaveDeleteBehavior/OnReturn.md)(…) |  |
| virtual [OnValidateRequest](BaseSaveDeleteBehavior/OnValidateRequest.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseSaveDeleteBehavior](BaseSaveDeleteBehavior/BaseSaveDeleteBehavior.md)() | The default constructor. |

## See Also

* class [BaseSaveBehavior](BaseSaveBehavior.md)
* interface [IDeleteBehavior](IDeleteBehavior.md)
* interface [IDeleteExceptionBehavior](IDeleteExceptionBehavior.md)
* **Source:** *[BaseSaveDeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Save/BaseSaveDeleteBehavior.cs)*