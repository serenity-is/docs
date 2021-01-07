# ISqlQueryExtensible interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Extensible SQL query interface. Used to abstract Serenity.Data.Row dependency from SqlQuery.

```csharp
public interface ISqlQueryExtensible
```

## Members

| name | description |
| --- | --- |
| [Columns](ISqlQueryExtensible/Columns.md) { get; } | Gets the columns. |
| [FirstIntoRow](ISqlQueryExtensible/FirstIntoRow.md) { get; } | Gets the first into row. |
| [IntoRows](ISqlQueryExtensible/IntoRows.md) { get; } | Gets the into rows. |
| [GetSelectIntoIndex](ISqlQueryExtensible/GetSelectIntoIndex.md)(…) | Gets the index of the select into. |
| [IntoRowSelection](ISqlQueryExtensible/IntoRowSelection.md)(…) | Selects the into row. |

## See Also

* **Source:** *[ISqlQueryExtensible.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/QueryModel/ISqlQueryExtensible.cs)*