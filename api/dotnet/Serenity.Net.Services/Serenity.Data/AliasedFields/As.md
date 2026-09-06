# AliasedFields.As&lt;TFields&gt; method

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

An instance of RowFieldsBase with T0 replaced with the specified alias.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias is null or whitespace. |

## See Also

* class [RowFieldsBase](../RowFieldsBase.md)
* class [AliasedFields](../AliasedFields.md)