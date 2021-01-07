# ForXmlHelper.ToRows&lt;TRow&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

```csharp
public static List<TRow> ToRows<TRow>(string forXml, Action<XElement, TRow> readRow)
    where TRow : class, IRow, new()
```

## See Also

* class [TRow](../Serenity.Net.Web/../ForXmlHelper.TRow.md)
* interface [IRow](../Serenity.Net.Entity/../IRow.md)
* class [ForXmlHelper](../ForXmlHelper.md)