# MasterDetailRelationBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior class that handles [`MasterDetailRelationAttribute`](../Serenity.Data.Mapping/MasterDetailRelationAttribute.md).

```csharp
public class MasterDetailRelationBehavior : BaseSaveDeleteBehaviorAsync, IDeleteBehaviorSync, 
    IFieldBehavior, IImplicitBehavior, IListBehaviorAsync, IListBehaviorSync, 
    IRetrieveBehaviorAsync, IRetrieveBehaviorSync, ISaveBehaviorSync
```

| parameter | description |
| --- | --- |
| handlerFactory | Default handler factory |

## Public Members

| name | description |
| --- | --- |
| [MasterDetailRelationBehavior](MasterDetailRelationBehavior/MasterDetailRelationBehavior.md)(…) | Behavior class that handles [`MasterDetailRelationAttribute`](../Serenity.Data.Mapping/MasterDetailRelationAttribute.md). |
| [Target](MasterDetailRelationBehavior/Target.md) { get; set; } |  |
| [ActivateFor](MasterDetailRelationBehavior/ActivateFor.md)(…) |  |
| virtual [OnAfterSave](MasterDetailRelationBehavior/OnAfterSave.md)(…) |  |
| override [OnAfterSaveAsync](MasterDetailRelationBehavior/OnAfterSaveAsync.md)(…) |  |
| virtual [OnBeforeDelete](MasterDetailRelationBehavior/OnBeforeDelete.md)(…) |  |
| override [OnBeforeDeleteAsync](MasterDetailRelationBehavior/OnBeforeDeleteAsync.md)(…) |  |
| virtual [OnReturn](MasterDetailRelationBehavior/OnReturn.md)(…) |  (2 methods) |
| virtual [OnReturnAsync](MasterDetailRelationBehavior/OnReturnAsync.md)(…) |  (2 methods) |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *handlerFactory* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* class [BaseSaveDeleteBehaviorAsync](./BaseSaveDeleteBehaviorAsync.md)
* interface [IDeleteBehaviorSync](./IDeleteBehaviorSync.md)
* interface [IFieldBehavior](./IFieldBehavior.md)
* interface [IImplicitBehavior](./IImplicitBehavior.md)
* interface [IListBehaviorAsync](./IListBehaviorAsync.md)
* interface [IListBehaviorSync](./IListBehaviorSync.md)
* interface [IRetrieveBehaviorAsync](./IRetrieveBehaviorAsync.md)
* interface [IRetrieveBehaviorSync](./IRetrieveBehaviorSync.md)
* interface [ISaveBehaviorSync](./ISaveBehaviorSync.md)
* **Source:** *[MasterDetailRelationBehavior.cs](https://github.com/serenity-is/Serenity/blob/63ce072b9679163702dbbb6e8202d62faebaa4a4/src/services/RequestHandlers/IntegratedFeatures/MasterDetail/MasterDetailRelationBehavior.cs)*