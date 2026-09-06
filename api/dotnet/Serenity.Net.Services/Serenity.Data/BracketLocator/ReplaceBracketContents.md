# BracketLocator.ReplaceBracketContents method

Replaces the bracket contents in SQL expression.

```csharp
public static string ReplaceBracketContents(string expression, char validChar1, 
    Func<string, string> replace)
```

| parameter | description |
| --- | --- |
| expression | The expression. |
| validChar1 | An additional character allowed to be in brackets. |
| replace | The replace function. |

## Return Value

The expression with bracket contents replaced.

## See Also

* class [BracketLocator](../BracketLocator.md)