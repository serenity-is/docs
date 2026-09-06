# LinkingSetRelationBehavior class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Behavior class that handles [`LinkingSetRelationAttribute`](../Serenity.Data.Mapping/LinkingSetRelationAttribute.md).

```csharp
public class LinkingSetRelationBehavior : BaseSaveDeleteBehaviorAsync, IDeleteBehaviorSync, 
    IFieldBehavior, IImplicitBehavior, IListBehaviorAsync, IListBehaviorSync, 
    IRetrieveBehaviorAsync, IRetrieveBehaviorSync, ISaveBehaviorSync
```

| parameter | description |
| --- | --- |
| handlerFactory | Default handler factory |

## Public Members

| name | description |
| --- | --- |
| [LinkingSetRelationBehavior](LinkingSetRelationBehavior/LinkingSetRelationBehavior.md)(…) | Behavior class that handles [`LinkingSetRelationAttribute`](../Serenity.Data.Mapping/LinkingSetRelationAttribute.md). |
| [Target](LinkingSetRelationBehavior/Target.md) { get; set; } |  |
| [ActivateFor](LinkingSetRelationBehavior/ActivateFor.md)(…) |  |
| virtual [OnAfterSave](LinkingSetRelationBehavior/OnAfterSave.md)(…) |  |
| override [OnAfterSaveAsync](LinkingSetRelationBehavior/OnAfterSaveAsync.md)(…) |  |
| virtual [OnBeforeDelete](LinkingSetRelationBehavior/OnBeforeDelete.md)(…) |  |
| override [OnBeforeDeleteAsync](LinkingSetRelationBehavior/OnBeforeDeleteAsync.md)(…) |  |
| virtual [OnPrepareQuery](LinkingSetRelationBehavior/OnPrepareQuery.md)(…) |  |
| virtual [OnPrepareQueryAsync](LinkingSetRelationBehavior/OnPrepareQueryAsync.md)(…) |  |
| virtual [OnReturn](LinkingSetRelationBehavior/OnReturn.md)(…) |  (2 methods) |
| virtual [OnReturnAsync](LinkingSetRelationBehavior/OnReturnAsync.md)(…) |  (2 methods) |

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
* **Source:** *[LinkingSetRelationBehavior.cs](https://github.com/serenity-is/Serenity/blob/8b22589557b8ad2f922b5a8d4de1b9e6034f2c0a/src/services/RequestHandlers/IntegratedFeatures/LinkingSetRelation/LinkingSetRelationBehavior.cs)*