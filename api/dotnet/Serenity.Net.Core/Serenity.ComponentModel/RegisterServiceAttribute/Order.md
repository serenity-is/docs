# RegisterServiceAttribute.Order property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Gets or sets the order of registration. Services with lower order will be registered first. This can be used to ensure that certain services are registered before others, e.g. when multiple implementations of the same service type are registered and the order matters. The default value is 0, and a higher value means a later registration.

```csharp
public int Order { get; set; }
```

## See Also

* class [RegisterServiceAttribute](../RegisterServiceAttribute.md)