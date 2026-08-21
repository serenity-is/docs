# DefaultHandlerRegistry constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Default implementation for the [`IDefaultHandlerRegistry`](../IDefaultHandlerRegistry.md).

```csharp
public DefaultHandlerRegistry(ITypeSource typeSource)
```

| parameter | description |
| --- | --- |
| typeSource | Type source containing possible handler classes. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *typeSource* is `null`. |

## Remarks

Initializes a new instance of the class.

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [DefaultHandlerRegistry](../DefaultHandlerRegistry.md)