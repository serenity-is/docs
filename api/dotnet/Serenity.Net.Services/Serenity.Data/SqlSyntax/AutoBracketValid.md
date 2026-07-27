# SqlSyntax.AutoBracketValid method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Automatically brackets the string based on dialect.AutoQuotedIdentifier setting, only if the identifier is valid.

```csharp
public static string AutoBracketValid(string s, ISqlDialect dialect = null)
```

| parameter | description |
| --- | --- |
| s | The string. |
| dialect | Target dialect, SqlSettings.DefaultDialect is used if null. |

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSyntax](../SqlSyntax.md)