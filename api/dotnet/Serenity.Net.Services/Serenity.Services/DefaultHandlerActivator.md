# DefaultHandlerActivator class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default implementation of the [`IHandlerActivator`](./IHandlerActivator.md).

```csharp
public class DefaultHandlerActivator : IHandlerActivator
```

| parameter | description |
| --- | --- |
| provider | Service provider |

## Public Members

| name | description |
| --- | --- |
| [DefaultHandlerActivator](DefaultHandlerActivator/DefaultHandlerActivator.md)(…) | Default implementation of the [`IHandlerActivator`](./IHandlerActivator.md). |
| [CreateInstance](DefaultHandlerActivator/CreateInstance.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *provider* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [IHandlerActivator](./IHandlerActivator.md)
* **Source:** *[DefaultHandlerActivator.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/RequestHandlers/Handler/DefaultHandlerActivator.cs)*