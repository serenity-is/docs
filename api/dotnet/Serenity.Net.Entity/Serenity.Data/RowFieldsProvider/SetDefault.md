# RowFieldsProvider.SetDefault method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Sets default row fields provider. This instance is required as rows might have to be created in contexts where dependency injection is not possible, like deserialization. If using a DI container, set this at startup to the same singleton service you register with DI.

```csharp
public static IRowFieldsProvider SetDefault(IRowFieldsProvider provider)
```

| parameter | description |
| --- | --- |
| provider | Provider. Required. |

## Return Value

Old default provider

## See Also

* interface [IRowFieldsProvider](../IRowFieldsProvider.md)
* class [RowFieldsProvider](../RowFieldsProvider.md)