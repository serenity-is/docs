# DefaultRowFieldsProvider constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Default row fields instance provider, that resolves row fields instances using ActivatorUtilities.CreateInstance through a IServiceProvider.

```csharp
public DefaultRowFieldsProvider(IServiceProvider serviceProvider)
```

| parameter | description |
| --- | --- |
| serviceProvider | The service provider. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | serviceProvider |

## Remarks

Initializes a new instance of the [`DefaultRowFieldsProvider`](../DefaultRowFieldsProvider.md) class.

## See Also

* interface [IRowFieldsProvider](../IRowFieldsProvider.md)
* class [DefaultRowFieldsProvider](../DefaultRowFieldsProvider.md)