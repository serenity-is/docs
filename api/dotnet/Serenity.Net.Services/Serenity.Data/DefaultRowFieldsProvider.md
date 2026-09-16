# DefaultRowFieldsProvider class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default row fields instance provider, that resolves row fields instances using ActivatorUtilities.CreateInstance through a IServiceProvider.

```csharp
public class DefaultRowFieldsProvider : IRowFieldsProvider
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider. |

## Public Members

| name | description |
| --- | --- |
| [DefaultRowFieldsProvider](DefaultRowFieldsProvider/DefaultRowFieldsProvider.md)(…) | Default row fields instance provider, that resolves row fields instances using ActivatorUtilities.CreateInstance through a IServiceProvider. |
| [Resolve](DefaultRowFieldsProvider/Resolve.md)(…) | Resolves the fields instance for the specified fields type. |
| [ResolveWithAlias](DefaultRowFieldsProvider/ResolveWithAlias.md)(…) | Resolves the fields instance for the specified fields type with the given alias applied. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | serviceProvider |

## Remarks

Initializes a new instance of the [`DefaultRowFieldsProvider`](./DefaultRowFieldsProvider.md) class.

## See Also

* interface [IRowFieldsProvider](./IRowFieldsProvider.md)
* **Source:** *[DefaultRowFieldsProvider.cs](https://github.com/serenity-is/Serenity/blob/7d4534fc93adbd2968e8fbf317070a0cb6f67b1e/src/services/Entity/Row/DefaultRowFieldsProvider.cs)*