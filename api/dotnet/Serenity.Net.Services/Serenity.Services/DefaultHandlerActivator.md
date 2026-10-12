# DefaultHandlerActivator class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation of the [`IHandlerActivator`](./IHandlerActivator.md).

```csharp
public class DefaultHandlerActivator : IHandlerActivator
```

| parameter | description |
| --- | --- |
| serviceProviderAccessor | Accessor for the service provider used to resolve the services handler classes require |

## Public Members

| name | description |
| --- | --- |
| [DefaultHandlerActivator](DefaultHandlerActivator/DefaultHandlerActivator.md)(…) | Default implementation of the [`IHandlerActivator`](./IHandlerActivator.md). |
| [CreateInstance](DefaultHandlerActivator/CreateInstance.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *serviceProviderAccessor* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IHandlerActivator](./IHandlerActivator.md)
* **Source:** *[DefaultHandlerActivator.cs](https://github.com/serenity-is/Serenity/blob/df6fb676c90d207452f30ac96d17cc9ba967a264/src/services/RequestHandlers/Handler/DefaultHandlerActivator.cs)*