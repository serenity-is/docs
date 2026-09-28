# Sql.Expr&lt;T&gt; method

Marks a SQL expression as a projected value in a `QueryProjected` selector.

```csharp
public static T Expr<T>(string expression)
```

| parameter | description |
| --- | --- |
| T | The CLR type returned by the SQL expression. |
| expression | The SQL expression. |

## Return Value

This method is only interpreted from a projection expression tree.

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | expression is null or whitespace. |
| InvalidOperationException | This marker is used outside a projection selector. |

## See Also

* class [Sql](../Sql.md)