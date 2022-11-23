# BaseUndeleteBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for types implementing [`IUndeleteBehavior`](IUndeleteBehavior.md)

```csharp
public abstract class BaseUndeleteBehavior : IUndeleteBehavior, IUndeleteExceptionBehavior
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

* interface [IUndeleteBehavior](IUndeleteBehavior.md)
* interface [IUndeleteExceptionBehavior](IUndeleteExceptionBehavior.md)
* **Source:** *[BaseUndeleteBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/Undelete/BaseUndeleteBehavior.cs)*