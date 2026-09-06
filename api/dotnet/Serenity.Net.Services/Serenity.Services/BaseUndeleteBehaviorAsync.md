# BaseUndeleteBehaviorAsync class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for types implementing [`IUndeleteBehaviorAsync`](IUndeleteBehaviorAsync.md)

```csharp
public abstract class BaseUndeleteBehaviorAsync : IUndeleteBehaviorAsync, IUndeleteExceptionBehavior
```

## Public Members

| name | description |
| --- | --- |
| virtual [OnAfterUndeleteAsync](BaseUndeleteBehaviorAsync/OnAfterUndeleteAsync.md)(…) |  |
| virtual [OnAuditAsync](BaseUndeleteBehaviorAsync/OnAuditAsync.md)(…) |  |
| virtual [OnBeforeUndeleteAsync](BaseUndeleteBehaviorAsync/OnBeforeUndeleteAsync.md)(…) |  |
| virtual [OnException](BaseUndeleteBehaviorAsync/OnException.md)(…) |  |
| virtual [OnPrepareQueryAsync](BaseUndeleteBehaviorAsync/OnPrepareQueryAsync.md)(…) |  |
| virtual [OnReturnAsync](BaseUndeleteBehaviorAsync/OnReturnAsync.md)(…) |  |
| virtual [OnValidateRequestAsync](BaseUndeleteBehaviorAsync/OnValidateRequestAsync.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseUndeleteBehaviorAsync](BaseUndeleteBehaviorAsync/BaseUndeleteBehaviorAsync.md)() | The default constructor. |

## See Also

* interface [IUndeleteBehaviorAsync](IUndeleteBehaviorAsync.md)
* interface [IUndeleteExceptionBehavior](IUndeleteExceptionBehavior.md)
* **Source:** *[BaseUndeleteBehaviorAsync.cs](https://github.com/serenity-is/Serenity/blob/62e26a99abba7fd00c7409a1334581e3c5ccd1f4/src/services/RequestHandlers/Undelete/BaseUndeleteBehaviorAsync.cs)*