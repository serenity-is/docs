# MasterDetailRelationBehavior constructor

Behavior class that handles [`MasterDetailRelationAttribute`](../../Serenity.Data.Mapping/MasterDetailRelationAttribute.md).

```csharp
public MasterDetailRelationBehavior(IDefaultHandlerFactory handlerFactory)
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
* class [MasterDetailRelationBehavior](../MasterDetailRelationBehavior.md)