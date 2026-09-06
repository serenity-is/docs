# UniqueConstraintSaveBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior that handles [`UniqueConstraintAttribute`](../Serenity.Data.Mapping/UniqueConstraintAttribute.md).

```csharp
public class UniqueConstraintSaveBehavior : BaseSaveBehaviorAsync, IImplicitBehavior, 
    ISaveBehaviorSync
```

| parameter | description |
| --- | --- |
| localizer | Text localizer |

## Public Members

| name | description |
| --- | --- |
| [UniqueConstraintSaveBehavior](UniqueConstraintSaveBehavior/UniqueConstraintSaveBehavior.md)(…) | Behavior that handles [`UniqueConstraintAttribute`](../Serenity.Data.Mapping/UniqueConstraintAttribute.md). |
| [ActivateFor](UniqueConstraintSaveBehavior/ActivateFor.md)(…) |  |
| virtual [OnBeforeSave](UniqueConstraintSaveBehavior/OnBeforeSave.md)(…) |  |
| override [OnBeforeSaveAsync](UniqueConstraintSaveBehavior/OnBeforeSaveAsync.md)(…) |  |

## Remarks

Initializes a new instance of the class.

## See Also

* class [BaseSaveBehaviorAsync](./BaseSaveBehaviorAsync.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* **Source:** *[UniqueConstraintSaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/IntegratedFeatures/UniqueConstraints/UniqueConstraintSaveBehavior.cs)*