# UniqueFieldSaveBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface that handles [`UniqueConstraintAttribute`](../Serenity.Data.Mapping/UniqueConstraintAttribute.md) on fields.

```csharp
public class UniqueFieldSaveBehavior : BaseSaveBehaviorAsync, IFieldBehavior, IImplicitBehavior, 
    ISaveBehaviorSync
```

| parameter | description |
| --- | --- |
| localizer | Text localizer |

## Public Members

| name | description |
| --- | --- |
| [UniqueFieldSaveBehavior](UniqueFieldSaveBehavior/UniqueFieldSaveBehavior.md)(…) | Interface that handles [`UniqueConstraintAttribute`](../Serenity.Data.Mapping/UniqueConstraintAttribute.md) on fields. |
| [Target](UniqueFieldSaveBehavior/Target.md) { get; set; } |  |
| [ActivateFor](UniqueFieldSaveBehavior/ActivateFor.md)(…) |  |
| virtual [OnBeforeSave](UniqueFieldSaveBehavior/OnBeforeSave.md)(…) |  |
| override [OnBeforeSaveAsync](UniqueFieldSaveBehavior/OnBeforeSaveAsync.md)(…) |  |

## Remarks

Initializes a new instance of the class.

## See Also

* class [BaseSaveBehaviorAsync](./BaseSaveBehaviorAsync.md)
* interface [IFieldBehavior](./IFieldBehavior.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* **Source:** *[UniqueFieldSaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/7d4534fc93adbd2968e8fbf317070a0cb6f67b1e/src/services/RequestHandlers/IntegratedFeatures/UniqueConstraints/UniqueFieldSaveBehavior.cs)*