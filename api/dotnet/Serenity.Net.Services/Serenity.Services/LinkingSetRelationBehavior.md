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

Saving or deleting the linking set invokes the nested save/delete handler once per item (an N+1 pattern). This is intentional, so the full handler pipeline (behaviors, audit, concurrency version checks, unique constraints, cascades and cache invalidation) applies to every link row. Batching these into a single statement would bypass that pipeline and change the semantics, so it is not done. Callers with very large item sets should be aware of the resulting number of round trips.

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
* **Source:** *[LinkingSetRelationBehavior.cs](https://github.com/serenity-is/Serenity/blob/842eeed9c1017bb2110e654fdf17bd169a31f7a0/src/services/RequestHandlers/IntegratedFeatures/LinkingSetRelation/LinkingSetRelationBehavior.cs)*