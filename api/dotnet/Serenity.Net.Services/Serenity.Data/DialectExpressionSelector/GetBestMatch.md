# DialectExpressionSelector.GetBestMatch&lt;TAttribute&gt; method

Gets the best matching attribute for the current dialect.

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

## Return Value

The best matching attribute, or `null` if none match.

## See Also

* class [DialectExpressionSelector](../DialectExpressionSelector.md)