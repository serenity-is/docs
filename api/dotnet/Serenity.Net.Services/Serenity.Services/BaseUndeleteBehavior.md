# BaseUndeleteBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for types implementing [`IUndeleteBehaviorSync`](IUndeleteBehaviorSync.md)

```csharp
public abstract class BaseUndeleteBehavior : IUndeleteBehaviorSync, IUndeleteExceptionBehavior
```

## Public Members

| name | description |
| --- | --- |
| virtual [OnAfterUndelete](BaseUndeleteBehavior/OnAfterUndelete.md)(…) |  |
| virtual [OnAudit](BaseUndeleteBehavior/OnAudit.md)(…) |  |
| virtual [OnBeforeUndelete](BaseUndeleteBehavior/OnBeforeUndelete.md)(…) |  |
| virtual [OnException](BaseUndeleteBehavior/OnException.md)(…) |  |
| virtual [OnPrepareQuery](BaseUndeleteBehavior/OnPrepareQuery.md)(…) |  |
| virtual [OnReturn](BaseUndeleteBehavior/OnReturn.md)(…) |  |
| virtual [OnValidateRequest](BaseUndeleteBehavior/OnValidateRequest.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseUndeleteBehavior](BaseUndeleteBehavior/BaseUndeleteBehavior.md)() | The default constructor. |

## See Also

* interface [IUndeleteBehaviorSync](IUndeleteBehaviorSync.md)
* interface [IUndeleteExceptionBehavior](IUndeleteExceptionBehavior.md)
* **Source:** *[BaseUndeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/574b0f91eebdcc8cdd7f9af77f617c5cf3fc4aec/src/services/RequestHandlers/Undelete/BaseUndeleteBehavior.cs)*