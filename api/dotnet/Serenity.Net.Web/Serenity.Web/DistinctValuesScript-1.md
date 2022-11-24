# DistinctValuesScript&lt;TRow&gt; class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

A dynamic script type for distinct values of a field

```csharp
public class DistinctValuesScript<TRow> : LookupScript
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow |  |

## Public Members

| name | description |
| --- | --- |
| [DistinctValuesScript](DistinctValuesScript-1/DistinctValuesScript.md)(…) | Creates a new instance of the class |
| override [GetScript](DistinctValuesScript-1/GetScript.md)() |  |

## Protected Members

| name | description |
| --- | --- |
| virtual [ApplyOrder](DistinctValuesScript-1/ApplyOrder.md)(…) | Applies the sort order to the query |
| override [GetItems](DistinctValuesScript-1/GetItems.md)() |  |
| virtual [PrepareQuery](DistinctValuesScript-1/PrepareQuery.md)(…) | Prepares the sql query |

## See Also

* class [LookupScript](LookupScript.md)
* interface [IRow](../Serenity.Net.Entity/../Serenity.Data/IRow.md)
* **Source:** *[DistinctValuesScript.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/DynamicScript/DynamicScriptTypes/DistinctValuesScript.cs)*