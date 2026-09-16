# DefaultImplicitBehaviorRegistry constructor

Default implementation for the [`IImplicitBehaviorRegistry`](../IImplicitBehaviorRegistry.md)

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

## Remarks

Initializes a new instance of the class.

## See Also

* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [DefaultImplicitBehaviorRegistry](../DefaultImplicitBehaviorRegistry.md)