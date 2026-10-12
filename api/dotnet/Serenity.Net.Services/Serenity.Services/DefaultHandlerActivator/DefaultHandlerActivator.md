# DefaultHandlerActivator constructor

Default implementation of the [`IHandlerActivator`](../IHandlerActivator.md).

```csharp
public DefaultHandlerActivator(IServiceProviderAccessor serviceProviderAccessor)
```

| parameter | description |
| --- | --- |
| serviceProviderAccessor | Accessor for the service provider used to resolve the services handler classes require |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProviderAccessor* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IServiceProviderAccessor](../../../Serenity.Net.Core/Serenity/IServiceProviderAccessor.md)
* class [DefaultHandlerActivator](../DefaultHandlerActivator.md)