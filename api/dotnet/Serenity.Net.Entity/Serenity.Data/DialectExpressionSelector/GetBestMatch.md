# DialectExpressionSelector.GetBestMatch&lt;TAttribute&gt; method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Gets the best match.

```csharp
public TAttribute GetBestMatch<TAttribute>(IEnumerable<TAttribute> attributes, 
    Func<TAttribute, string> getDialect)
    where TAttribute : class
```

| parameter | description |
| --- | --- |
| TAttribute | The type of the attribute. |
| attributes | The expressions. |
| getDialect | The get dialect. |

## See Also

* class [TAttribute](../Serenity.Net.Entity/../DialectExpressionSelector.TAttribute.md)
* class [DialectExpressionSelector](../DialectExpressionSelector.md)