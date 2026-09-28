# ISqlQueryExtensible interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extensible SQL query interface. Used to abstract Serenity.Data.Row dependency from SqlQuery.

```csharp
public interface ISqlQueryExtensible
```

## Members

| name | description |
| --- | --- |
| [Columns](ISqlQueryExtensible/Columns.md) { get; } | Gets the columns. |
| [CurrentIntoRow](ISqlQueryExtensible/CurrentIntoRow.md) { get; } | Gets the currently selected into row. |
| [FirstIntoRow](ISqlQueryExtensible/FirstIntoRow.md) { get; } | Gets the first into row. |
| [FromSources](ISqlQueryExtensible/FromSources.md) { get; } | Gets the aliased sources added to the FROM clause. |
| [IntoRows](ISqlQueryExtensible/IntoRows.md) { get; } | Gets the into rows. |
| [JoinSources](ISqlQueryExtensible/JoinSources.md) { get; } | Gets the sources registered for resolving joins by alias. |
| [GetSelectIntoIndex](ISqlQueryExtensible/GetSelectIntoIndex.md)(…) | Gets the index of the select into. |
| [IntoRowSelection](ISqlQueryExtensible/IntoRowSelection.md)(…) | Selects the into row. |

## See Also

* **Source:** *[ISqlQueryExtensible.cs](https://github.com/serenity-is/Serenity/blob/a33f821b7a5431477e50f129ce63ce324c984018/src/services/Data/QueryModel/ISqlQueryExtensible.cs)*