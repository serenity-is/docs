# UpdatableExtensionBehavior constructor

Behavior that handles [`UpdatableExtensionAttribute`](../../Serenity.Data.Mapping/UpdatableExtensionAttribute.md).

```csharp
public UpdatableExtensionBehavior(IDefaultHandlerFactory handlerFactory)
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
* class [UpdatableExtensionBehavior](../UpdatableExtensionBehavior.md)