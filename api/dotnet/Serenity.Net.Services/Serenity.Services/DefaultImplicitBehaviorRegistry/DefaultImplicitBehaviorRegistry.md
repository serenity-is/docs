# DefaultImplicitBehaviorRegistry constructor
**namespace:** *[Serenity.Services](../../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Initializes a new instance of the class.

```csharp
public DefaultImplicitBehaviorRegistry(ITypeSource typeSource)
```

| parameter | description |
| --- | --- |
| typeSource | The type source to extract [`IImplicitBehavior`](../IImplicitBehavior.md) types from |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | *typeSource* is `null`. |

## See Also

* interface [ITypeSource](../Serenity.Net.Core/../../Serenity.Abstractions/ITypeSource.md)
* class [DefaultImplicitBehaviorRegistry](../DefaultImplicitBehaviorRegistry.md)