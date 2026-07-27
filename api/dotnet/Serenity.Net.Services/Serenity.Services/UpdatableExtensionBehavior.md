# UpdatableExtensionBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior that handles [`UpdatableExtensionAttribute`](../Serenity.Data.Mapping/UpdatableExtensionAttribute.md)

```csharp
public class UpdatableExtensionBehavior : BaseSaveDeleteBehavior, IImplicitBehavior
```

| parameter | description |
| --- | --- |
| handlerFactory | Default handler factory |

## Public Members

| name | description |
| --- | --- |
| [UpdatableExtensionBehavior](UpdatableExtensionBehavior/UpdatableExtensionBehavior.md)(…) | Behavior that handles [`UpdatableExtensionAttribute`](../Serenity.Data.Mapping/UpdatableExtensionAttribute.md) |
| [ActivateFor](UpdatableExtensionBehavior/ActivateFor.md)(…) |  |
| override [OnAfterSave](UpdatableExtensionBehavior/OnAfterSave.md)(…) |  |
| override [OnBeforeDelete](UpdatableExtensionBehavior/OnBeforeDelete.md)(…) |  |
| override [OnBeforeSave](UpdatableExtensionBehavior/OnBeforeSave.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | handlerFactory is null |

## Remarks

Creates a new instance of the class

## See Also

* class [BaseSaveDeleteBehavior](BaseSaveDeleteBehavior.md)
* interface [IImplicitBehavior](IImplicitBehavior.md)
* **Source:** *[UpdatableExtensionBehavior.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/RequestHandlers/IntegratedFeatures/UpdatableExtension/UpdatableExtensionBehavior.cs)*