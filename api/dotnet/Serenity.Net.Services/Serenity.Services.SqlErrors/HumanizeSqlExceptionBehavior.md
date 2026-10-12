# HumanizeSqlExceptionBehavior class
**namespace:** *[Serenity.Services.SqlErrors](../README.md#serenity.services.sqlerrors-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Implicit save/delete/undelete behavior that converts recognized database constraint violations (primary key, unique, foreign key, not null) into localized ValidationErrors using [`ISqlErrorExtractor`](./ISqlErrorExtractor.md) and [`ToString`](./SqlErrorInfo/ToString.md) instead of letting the raw provider exception surface as a server error.

```csharp
public class HumanizeSqlExceptionBehavior : IDeleteBehaviorSync, IDeleteExceptionBehavior, 
    IImplicitBehavior, ISaveBehaviorSync, ISaveExceptionBehavior, IUndeleteBehaviorSync, 
    IUndeleteExceptionBehavior
```

| parameter | description |
| --- | --- |
| extractor | SQL error extractor. |

## Public Members

| name | description |
| --- | --- |
| [HumanizeSqlExceptionBehavior](HumanizeSqlExceptionBehavior/HumanizeSqlExceptionBehavior.md)(…) | Implicit save/delete/undelete behavior that converts recognized database constraint violations (primary key, unique, foreign key, not null) into localized ValidationErrors using [`ISqlErrorExtractor`](./ISqlErrorExtractor.md) and [`ToString`](./SqlErrorInfo/ToString.md) instead of letting the raw provider exception surface as a server error. |
| [ActivateFor](HumanizeSqlExceptionBehavior/ActivateFor.md)(…) |  |
| [OnException](HumanizeSqlExceptionBehavior/OnException.md)(…) |  (3 methods) |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *extractor* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IDeleteBehaviorSync](../Serenity.Services/IDeleteBehaviorSync.md)
* interface [IDeleteExceptionBehavior](../Serenity.Services/IDeleteExceptionBehavior.md)
* interface [IImplicitBehavior](../Serenity.Services/IImplicitBehavior.md)
* interface [ISaveBehaviorSync](../Serenity.Services/ISaveBehaviorSync.md)
* interface [ISaveExceptionBehavior](../Serenity.Services/ISaveExceptionBehavior.md)
* interface [IUndeleteBehaviorSync](../Serenity.Services/IUndeleteBehaviorSync.md)
* interface [IUndeleteExceptionBehavior](../Serenity.Services/IUndeleteExceptionBehavior.md)
* **Source:** *[HumanizeSqlExceptionBehavior.cs](https://github.com/serenity-is/Serenity/blob/a679f1028db82d58ffab223dfa74a87eaf54bfc2/src/services/RequestHandlers/IntegratedFeatures/SqlErrors/HumanizeSqlExceptionBehavior.cs)*