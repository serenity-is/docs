# UniqueFieldSaveBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Interface that handles UniqueConstraintAttribute on fields

```csharp
public class UniqueFieldSaveBehavior : BaseSaveBehavior, IFieldBehavior, IImplicitBehavior
```

## Public Members

| name | description |
| --- | --- |
| [UniqueFieldSaveBehavior](UniqueFieldSaveBehavior/UniqueFieldSaveBehavior.md)(…) | Creates a new instance of the class |
| [Target](UniqueFieldSaveBehavior/Target.md) { get; set; } |  |
| [ActivateFor](UniqueFieldSaveBehavior/ActivateFor.md)(…) |  |
| override [OnBeforeSave](UniqueFieldSaveBehavior/OnBeforeSave.md)(…) |  |

## See Also

* class [BaseSaveBehavior](BaseSaveBehavior.md)
* interface [IFieldBehavior](IFieldBehavior.md)
* interface [IImplicitBehavior](IImplicitBehavior.md)
* **Source:** *[UniqueFieldSaveBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/RequestHandlers/IntegratedFeatures/UniqueConstraints/UniqueFieldSaveBehavior.cs)*