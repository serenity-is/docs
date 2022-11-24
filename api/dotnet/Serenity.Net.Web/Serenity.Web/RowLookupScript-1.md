# RowLookupScript&lt;TRow&gt; class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Generic lookup script type for rows

```csharp
public class RowLookupScript<TRow> : LookupScript
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Row type |

## Public Members

| name | description |
| --- | --- |
| [RowLookupScript](RowLookupScript-1/RowLookupScript.md)(…) | Creates a new instance of the class |

## Protected Members

| name | description |
| --- | --- |
| virtual [ApplyOrder](RowLookupScript-1/ApplyOrder.md)(…) | Applies the sort order to the query |
| override [GetItems](RowLookupScript-1/GetItems.md)() |  |
| virtual [PrepareQuery](RowLookupScript-1/PrepareQuery.md)(…) | Prepares the sql query to select fields |

## See Also

* class [LookupScript](LookupScript.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* **Source:** *[RowLookupScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScriptTypes/RowLookupScript.cs)*