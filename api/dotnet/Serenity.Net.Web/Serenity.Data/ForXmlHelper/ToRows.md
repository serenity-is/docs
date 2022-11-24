# ForXmlHelper.ToRows&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Converts data returned from FOR XML statement to a row type

```csharp
public static List<TRow> ToRows<TRow>(string forXml, Action<XElement, TRow> readRow)
    where TRow : class, IRow, new()
```

| parameter | description |
| --- | --- |
| TRow | Target row type |
| forXml | Returned FOR XML data |
| readRow | Action to read a row |

## See Also

* class [TRow](../Serenity.Net.Web/../ForXmlHelper.TRow.md)
* interface [IRow](../Serenity.Net.Entity/../IRow.md)
* class [ForXmlHelper](../ForXmlHelper.md)