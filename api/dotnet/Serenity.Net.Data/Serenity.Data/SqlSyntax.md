# SqlSyntax class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Contains SQL syntax helpers.

```csharp
public static class SqlSyntax
```

## Public Members

| name | description |
| --- | --- |
| static [AutoBracket](SqlSyntax/AutoBracket.md)(…) | Automatically brackets the string based on SqlSettings.AutoQuotedIdentifier setting. |
| static [AutoBracketValid](SqlSyntax/AutoBracketValid.md)(…) | Automatically brackets the string based on SqlSettings.AutoQuotedIdentifier setting, only if the identifier is valid. |
| static [IndexParam](SqlSyntax/IndexParam.md)(…) | Returns an indexed parameter name like @p123. |
| static [IsQuoted](SqlSyntax/IsQuoted.md)(…) | Determines whether the specified string is quoted. |
| static [IsValidIdentifier](SqlSyntax/IsValidIdentifier.md)(…) | Determines whether the specified string is a valid SQL identifier. |
| static [IsValidQuotedIdentifier](SqlSyntax/IsValidQuotedIdentifier.md)(…) | Determines whether the specified string is a valid quoted SQL identifier. |
| static [TableAlias](SqlSyntax/TableAlias.md)(…) | Creates a table alias like T0 |
| static [TableAliasDot](SqlSyntax/TableAliasDot.md)(…) | Creates a table alias dot like "T0." |
| static [Unquote](SqlSyntax/Unquote.md)(…) | Unquotes the specified string. |

## See Also

* **Source:** *[SqlSyntax.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/SqlHelpers/SqlSyntax.cs)*