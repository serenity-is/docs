# DefaultRowTypeRegistry class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default row type registry

```csharp
public class DefaultRowTypeRegistry : IRowTypeRegistry
```

| parameter | description |
| --- | --- |
| typeSource | The type source. |

## Public Members

| name | description |
| --- | --- |
| [DefaultRowTypeRegistry](DefaultRowTypeRegistry/DefaultRowTypeRegistry.md)(…) | Default row type registry |
| [AllRowTypes](DefaultRowTypeRegistry/AllRowTypes.md) { get; } | Gets all row types. |
| [ByConnectionKey](DefaultRowTypeRegistry/ByConnectionKey.md)(…) | Returns row types by the connection key. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | typeSource |

## Remarks

Initializes a new instance of the [`DefaultRowTypeRegistry`](DefaultRowTypeRegistry.md) class.

## See Also

* interface [IRowTypeRegistry](IRowTypeRegistry.md)
* **Source:** *[DefaultRowTypeRegistry.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/Row/DefaultRowTypeRegistry.cs)*