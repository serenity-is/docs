# RowFieldsBase.ReplaceAliasWith method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Replaces the alias with.

```csharp
public void ReplaceAliasWith(string newAlias)
```

| parameter | description |
| --- | --- |
| newAlias | The new alias. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | newAlias |
| InvalidOperationException | Please use As() method to alias this fields object! |

## See Also

* class [RowFieldsBase](../RowFieldsBase.md)