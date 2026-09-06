# DefaultHandlerFactory constructor

Default implementation for the [`IDefaultHandlerFactory`](../IDefaultHandlerFactory.md).

```csharp
public DefaultHandlerFactory(IDefaultHandlerRegistry registry, IHandlerActivator activator)
```

| parameter | description |
| --- | --- |
| registry | Default handler registry |
| activator | Handler activator |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *registry* or *activator* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IDefaultHandlerRegistry](../IDefaultHandlerRegistry.md)
* interface [IHandlerActivator](../IHandlerActivator.md)
* class [DefaultHandlerFactory](../DefaultHandlerFactory.md)