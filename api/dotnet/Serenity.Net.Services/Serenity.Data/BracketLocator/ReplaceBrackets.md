# BracketLocator.ReplaceBrackets method

Replaces the brackets in an SQL expression with the dialect specific ones.

```csharp
public static string? ReplaceBrackets(string? expression, ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| dialect | The dialect. |

## Return Value

The expression with brackets replaced.

## Remarks

Quoted regions and comments are skipped via SqlRegionScanner, so a "[" inside them never pairs forward into real SQL. A lone '/' (division) falls through untouched.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [BracketLocator](../BracketLocator.md)