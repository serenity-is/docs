# DefaultHandlerRegistry constructor

Initializes a new instance of the class.

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

## See Also

* interface [ITypeSource](../../../Serenity.Net.Core/Serenity.Abstractions/ITypeSource.md)
* class [DefaultHandlerRegistry](../DefaultHandlerRegistry.md)