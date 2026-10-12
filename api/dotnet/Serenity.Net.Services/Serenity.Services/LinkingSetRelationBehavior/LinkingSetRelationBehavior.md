# LinkingSetRelationBehavior constructor

Behavior class that handles [`LinkingSetRelationAttribute`](../../Serenity.Data.Mapping/LinkingSetRelationAttribute.md).

```csharp
public LinkingSetRelationBehavior(IDefaultHandlerFactory handlerFactory)
```

| parameter | description |
| --- | --- |
| handlerFactory | Default handler factory |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *handlerFactory* is `null`. |

## Remarks

Initializes a new instance of the class.

Saving or deleting the linking set invokes the nested save/delete handler once per item (an N+1 pattern). This is intentional, so the full handler pipeline (behaviors, audit, concurrency version checks, unique constraints, cascades and cache invalidation) applies to every link row. Batching these into a single statement would bypass that pipeline and change the semantics, so it is not done. Callers with very large item sets should be aware of the resulting number of round trips.

## See Also

* interface [IDefaultHandlerFactory](../IDefaultHandlerFactory.md)
* class [LinkingSetRelationBehavior](../LinkingSetRelationBehavior.md)