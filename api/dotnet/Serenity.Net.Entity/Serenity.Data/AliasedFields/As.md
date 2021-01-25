# AliasedFields.As&lt;TFields&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Aliases the fields with the specified alias.

```csharp
public static TFields As<TFields>(this TFields fields, string alias)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The type of the fields. |
| fields | The fields. |
| alias | The alias. |

## Return Value

An instance of RowFieldsBase with T0 replaced with specified alias

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias |

## See Also

* class [TFields](../Serenity.Net.Entity/../AliasedFields.TFields.md)
* class [RowFieldsBase](../RowFieldsBase.md)
* class [AliasedFields](../AliasedFields.md)