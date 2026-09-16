# UpdatableExtensionBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior that handles [`UpdatableExtensionAttribute`](../Serenity.Data.Mapping/UpdatableExtensionAttribute.md).

```csharp
public class UpdatableExtensionBehavior : BaseSaveDeleteBehaviorAsync, IDeleteBehaviorSync, 
    IImplicitBehavior, ISaveBehaviorSync
```

| parameter | description |
| --- | --- |
| handlerFactory | Default handler factory |

## Public Members

| name | description |
| --- | --- |
| [UpdatableExtensionBehavior](UpdatableExtensionBehavior/UpdatableExtensionBehavior.md)(…) | Behavior that handles [`UpdatableExtensionAttribute`](../Serenity.Data.Mapping/UpdatableExtensionAttribute.md). |
| [ActivateFor](UpdatableExtensionBehavior/ActivateFor.md)(…) |  |
| virtual [OnAfterSave](UpdatableExtensionBehavior/OnAfterSave.md)(…) |  |
| override [OnAfterSaveAsync](UpdatableExtensionBehavior/OnAfterSaveAsync.md)(…) |  |
| virtual [OnBeforeDelete](UpdatableExtensionBehavior/OnBeforeDelete.md)(…) |  |
| override [OnBeforeDeleteAsync](UpdatableExtensionBehavior/OnBeforeDeleteAsync.md)(…) |  |
| virtual [OnBeforeSave](UpdatableExtensionBehavior/OnBeforeSave.md)(…) |  |
| override [OnBeforeSaveAsync](UpdatableExtensionBehavior/OnBeforeSaveAsync.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *handlerFactory* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [BaseSaveDeleteBehaviorAsync](./BaseSaveDeleteBehaviorAsync.md)
* interface [IDeleteBehaviorSync](./IDeleteBehaviorSync.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* **Source:** *[UpdatableExtensionBehavior.cs](https://github.com/serenity-is/Serenity/blob/7d4534fc93adbd2968e8fbf317070a0cb6f67b1e/src/services/RequestHandlers/IntegratedFeatures/UpdatableExtension/UpdatableExtensionBehavior.cs)*