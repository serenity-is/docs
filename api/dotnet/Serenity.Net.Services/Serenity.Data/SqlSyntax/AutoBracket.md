# SqlSyntax.AutoBracket method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Automatically brackets the string based on SqlSettings.AutoQuotedIdentifier setting and keywords for the passed dialect.

```csharp
public static string AutoBracket(string s, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| s | The string. |
| dialect | The dialect |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSyntax](../SqlSyntax.md)