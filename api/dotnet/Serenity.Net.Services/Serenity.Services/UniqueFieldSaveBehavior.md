# UniqueFieldSaveBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior that handles [`UniqueAttribute`](../Serenity.Data.Mapping/UniqueAttribute.md) on a single field. It checks the unique constraint before save (unless [`CheckBeforeSave`](../Serenity.Data.Mapping/UniqueAttribute/CheckBeforeSave.md) is disabled) by running an existence query. Override [`BuildUniqueConstraintQuery`](./BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md) in a derived behavior, or add your own behavior and set [`DisableDefaultBehavior`](../Serenity.Data.Mapping/UniqueAttribute/DisableDefaultBehavior.md) on the field, to customize or replace the pre-check.

```csharp
public class UniqueFieldSaveBehavior : BaseUniqueConstraintSaveBehavior, IFieldBehavior, 
    IImplicitBehavior
```

| parameter | description |
| --- | --- |
| localizer | Text localizer |

## Public Members

| name | description |
| --- | --- |
| [UniqueFieldSaveBehavior](UniqueFieldSaveBehavior/UniqueFieldSaveBehavior.md)(…) | Behavior that handles [`UniqueAttribute`](../Serenity.Data.Mapping/UniqueAttribute.md) on a single field. It checks the unique constraint before save (unless [`CheckBeforeSave`](../Serenity.Data.Mapping/UniqueAttribute/CheckBeforeSave.md) is disabled) by running an existence query. Override [`BuildUniqueConstraintQuery`](./BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md) in a derived behavior, or add your own behavior and set [`DisableDefaultBehavior`](../Serenity.Data.Mapping/UniqueAttribute/DisableDefaultBehavior.md) on the field, to customize or replace the pre-check. |
| [Target](UniqueFieldSaveBehavior/Target.md) { get; set; } |  |
| [ActivateFor](UniqueFieldSaveBehavior/ActivateFor.md)(…) |  |
| virtual [OnBeforeSave](UniqueFieldSaveBehavior/OnBeforeSave.md)(…) |  |
| override [OnBeforeSaveAsync](UniqueFieldSaveBehavior/OnBeforeSaveAsync.md)(…) |  |

## Remarks

Initializes a new instance of the class.

## See Also

* class [BaseUniqueConstraintSaveBehavior](./BaseUniqueConstraintSaveBehavior.md)
* interface [IFieldBehavior](./IFieldBehavior.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* **Source:** *[UniqueFieldSaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/RequestHandlers/IntegratedFeatures/UniqueConstraints/UniqueFieldSaveBehavior.cs)*