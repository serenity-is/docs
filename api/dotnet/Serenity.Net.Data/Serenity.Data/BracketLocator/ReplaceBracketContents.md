# BracketLocator.ReplaceBracketContents method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

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

## See Also

* class [BracketLocator](../BracketLocator.md)