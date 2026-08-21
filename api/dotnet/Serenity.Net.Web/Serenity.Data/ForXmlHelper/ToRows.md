# ForXmlHelper.ToRows&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Converts data returned from a `FOR XML` statement to a row type.

```csharp
public static List<TRow> ToRows<TRow>(string forXml, Action<XElement, TRow> readRow)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | The target row type. |
| forXml | The returned `FOR XML` data. |
| readRow | The action to read a row. |

## Return Value

The list of rows.

## See Also

* class [TRow](../Serenity.Net.Web/../ForXmlHelper.TRow.md)
* interface [IRow](../Serenity.Net.Services/../IRow.md)
* class [ForXmlHelper](../ForXmlHelper.md)