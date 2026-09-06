# DefaultHandlerFactory class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation for the [`IDefaultHandlerFactory`](./IDefaultHandlerFactory.md).

```csharp
public class DefaultHandlerFactory : IDefaultHandlerFactory
```

| parameter | description |
| --- | --- |
| registry | Default handler registry |
| activator | Handler activator |

## Public Members

| name | description |
| --- | --- |
| [DefaultHandlerFactory](DefaultHandlerFactory/DefaultHandlerFactory.md)(…) | Default implementation for the [`IDefaultHandlerFactory`](./IDefaultHandlerFactory.md). |
| [CreateHandler](DefaultHandlerFactory/CreateHandler.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *registry* or *activator* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IDefaultHandlerFactory](./IDefaultHandlerFactory.md)
* **Source:** *[DefaultHandlerFactory.cs](https://github.com/serenity-is/Serenity/blob/04ac3ea58a41048bed911555c87969edcf6ea031/src/services/RequestHandlers/Handler/DefaultHandlerFactory.cs)*