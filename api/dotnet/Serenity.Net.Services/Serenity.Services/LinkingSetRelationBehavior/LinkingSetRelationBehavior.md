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

## See Also

* interface [IDefaultHandlerFactory](../IDefaultHandlerFactory.md)
* class [LinkingSetRelationBehavior](../LinkingSetRelationBehavior.md)