# RowLookupScript&lt;TRow&gt; class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Generic lookup script type for rows.

```csharp
public class RowLookupScript<TRow> : LookupScript
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The row type. |

## Public Members

| name | description |
| --- | --- |
| [RowLookupScript](RowLookupScript-1/RowLookupScript.md)(…) | Initializes a new instance of the [`RowLookupScript`](RowLookupScript-1.md) class. |

## Protected Members

| name | description |
| --- | --- |
| readonly [sqlConnections-](RowLookupScript-1/sqlConnections-.md) | The SQL connections. |
| virtual [ApplyOrder](RowLookupScript-1/ApplyOrder.md)(…) | Applies the sort order to the query. |
| override [GetItems](RowLookupScript-1/GetItems.md)() |  |
| virtual [PrepareQuery](RowLookupScript-1/PrepareQuery.md)(…) | Prepares the SQL query to select fields. |

## See Also

* class [LookupScript](LookupScript.md)
* interface [IRow](../Serenity.Net.Services/../Serenity.Data/IRow.md)
* **Source:** *[RowLookupScript.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/DynamicScript/DynamicScriptTypes/RowLookupScript.cs)*