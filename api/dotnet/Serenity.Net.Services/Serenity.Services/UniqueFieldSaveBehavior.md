# UniqueFieldSaveBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface that handles [`UniqueConstraintAttribute`](../Serenity.Data.Mapping/UniqueConstraintAttribute.md) on fields

```csharp
public class UniqueFieldSaveBehavior : BaseSaveBehavior, IFieldBehavior, IImplicitBehavior
```

| parameter | description |
| --- | --- |
| localizer | Text localizer |

## Public Members

| name | description |
| --- | --- |
| [UniqueFieldSaveBehavior](UniqueFieldSaveBehavior/UniqueFieldSaveBehavior.md)(…) | Interface that handles [`UniqueConstraintAttribute`](../Serenity.Data.Mapping/UniqueConstraintAttribute.md) on fields |
| [Target](UniqueFieldSaveBehavior/Target.md) { get; set; } |  |
| [ActivateFor](UniqueFieldSaveBehavior/ActivateFor.md)(…) |  |
| override [OnBeforeSave](UniqueFieldSaveBehavior/OnBeforeSave.md)(…) |  |

## Remarks

Creates a new instance of the class

## See Also

* class [BaseSaveBehavior](BaseSaveBehavior.md)
* interface [IFieldBehavior](IFieldBehavior.md)
* interface [IImplicitBehavior](IImplicitBehavior.md)
* **Source:** *[UniqueFieldSaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/IntegratedFeatures/UniqueConstraints/UniqueFieldSaveBehavior.cs)*