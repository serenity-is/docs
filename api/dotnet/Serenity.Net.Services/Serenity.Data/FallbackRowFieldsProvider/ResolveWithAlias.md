# FallbackRowFieldsProvider.ResolveWithAlias method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Resolves the fields instance for the specified fields type with the given alias applied.

```csharp
public RowFieldsBase ResolveWithAlias(Type fieldsType, string alias)
```

| parameter | description |
| --- | --- |
| fieldsType | Type of the fields. |
| alias | The alias. |

## Return Value

The resolved fields instance with the specified alias applied.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias |

## See Also

* class [RowFieldsBase](../RowFieldsBase.md)
* class [FallbackRowFieldsProvider](../FallbackRowFieldsProvider.md)