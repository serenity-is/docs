# ForXmlHelper.ToRows&lt;TRow&gt; method

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

* interface [IRow](../../../Serenity.Net.Services/Serenity.Data/IRow.md)
* class [ForXmlHelper](../ForXmlHelper.md)