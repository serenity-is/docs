# UniqueConstraintSaveBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior that handles [`UniqueConstraintAttribute`](../Serenity.Data.Mapping/UniqueConstraintAttribute.md) on a row. It checks each unique constraint before save (unless [`CheckBeforeSave`](../Serenity.Data.Mapping/UniqueConstraintAttribute/CheckBeforeSave.md) is disabled) by running an existence query. Override [`BuildUniqueConstraintQuery`](./BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md) in a derived behavior, or add your own behavior and set [`DisableDefaultBehavior`](../Serenity.Data.Mapping/UniqueConstraintAttribute/DisableDefaultBehavior.md), to customize or replace the pre-check.

```csharp
public class UniqueConstraintSaveBehavior : BaseUniqueConstraintSaveBehavior, IImplicitBehavior
```

| parameter | description |
| --- | --- |
| localizer | Text localizer |

## Public Members

| name | description |
| --- | --- |
| [UniqueConstraintSaveBehavior](UniqueConstraintSaveBehavior/UniqueConstraintSaveBehavior.md)(…) | Behavior that handles [`UniqueConstraintAttribute`](../Serenity.Data.Mapping/UniqueConstraintAttribute.md) on a row. It checks each unique constraint before save (unless [`CheckBeforeSave`](../Serenity.Data.Mapping/UniqueConstraintAttribute/CheckBeforeSave.md) is disabled) by running an existence query. Override [`BuildUniqueConstraintQuery`](./BaseUniqueConstraintSaveBehavior/BuildUniqueConstraintQuery.md) in a derived behavior, or add your own behavior and set [`DisableDefaultBehavior`](../Serenity.Data.Mapping/UniqueConstraintAttribute/DisableDefaultBehavior.md), to customize or replace the pre-check. |
| [ActivateFor](UniqueConstraintSaveBehavior/ActivateFor.md)(…) |  |
| virtual [OnBeforeSave](UniqueConstraintSaveBehavior/OnBeforeSave.md)(…) |  |
| override [OnBeforeSaveAsync](UniqueConstraintSaveBehavior/OnBeforeSaveAsync.md)(…) |  |

## Remarks

Initializes a new instance of the class.

## See Also

* class [BaseUniqueConstraintSaveBehavior](./BaseUniqueConstraintSaveBehavior.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* **Source:** *[UniqueConstraintSaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/129785379640a01aa65d383053b7eb95a1f6890d/src/services/RequestHandlers/IntegratedFeatures/UniqueConstraints/UniqueConstraintSaveBehavior.cs)*