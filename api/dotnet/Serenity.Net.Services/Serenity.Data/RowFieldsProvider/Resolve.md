# RowFieldsProvider.Resolve&lt;TFields&gt; method (1 of 2)

Resolves a fields class using current row fields provider

```csharp
public static TFields Resolve<TFields>()
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The type of the fields. |

## See Also

* class [RowFieldsBase](../RowFieldsBase.md)
* class [RowFieldsProvider](../RowFieldsProvider.md)

---

# RowFieldsProvider.Resolve&lt;TFields&gt; method (2 of 2)

Resolves an aliased fields class using current row fields provider

```csharp
public static TFields Resolve<TFields>(string alias)
    where TFields : RowFieldsBase
```

| parameter | description |
| --- | --- |
| TFields | The type of the fields. |
| alias | Alias for fields |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | alias |

## See Also

* class [RowFieldsBase](../RowFieldsBase.md)
* class [RowFieldsProvider](../RowFieldsProvider.md)