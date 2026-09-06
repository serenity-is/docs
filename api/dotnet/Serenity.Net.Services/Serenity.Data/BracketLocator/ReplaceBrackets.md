# BracketLocator.ReplaceBrackets method

Replaces the brackets in an SQL expression with the dialect specific ones.

```csharp
public static string ReplaceBrackets(string expression, ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| dialect | The dialect. |

## Return Value

The expression with brackets replaced.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [BracketLocator](../BracketLocator.md)