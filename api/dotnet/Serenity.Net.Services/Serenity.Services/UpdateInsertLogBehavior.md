# UpdateInsertLogBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior class that handles assignment of relevant fields for rows with [`IInsertLogRow`](../Serenity.Data/IInsertLogRow.md) and [`IUpdateLogRow`](../Serenity.Data/IUpdateLogRow.md) interfaces

```csharp
public class UpdateInsertLogBehavior : BaseSaveBehaviorAsync, IImplicitBehavior, ISaveBehaviorSync
```

## Public Members

| name | description |
| --- | --- |
| [UpdateInsertLogBehavior](UpdateInsertLogBehavior/UpdateInsertLogBehavior.md)() | The default constructor. |
| [ActivateFor](UpdateInsertLogBehavior/ActivateFor.md)(…) |  |
| virtual [OnSetInternalFields](UpdateInsertLogBehavior/OnSetInternalFields.md)(…) |  |
| override [OnSetInternalFieldsAsync](UpdateInsertLogBehavior/OnSetInternalFieldsAsync.md)(…) |  |

## See Also

* class [BaseSaveBehaviorAsync](./BaseSaveBehaviorAsync.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* **Source:** *[InsertUpdateLogBehavior.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/IntegratedFeatures/InsertUpdateLog/InsertUpdateLogBehavior.cs)*