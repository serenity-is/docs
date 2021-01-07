# RowLookupScript&lt;TRow&gt; class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

```csharp
public class RowLookupScript<TRow> : LookupScript
    where TRow : class, IRow, new()
```

## Public Members

| name | description |
| --- | --- |
| [RowLookupScript](RowLookupScript-1/RowLookupScript.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| virtual [ApplyOrder](RowLookupScript-1/ApplyOrder.md)(…) |  |
| override [GetItems](RowLookupScript-1/GetItems.md)() |  |
| virtual [PrepareQuery](RowLookupScript-1/PrepareQuery.md)(…) |  |

## See Also

* class [LookupScript](LookupScript.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* **Source:** *[RowLookupScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScriptTypes/RowLookupScript.cs)*