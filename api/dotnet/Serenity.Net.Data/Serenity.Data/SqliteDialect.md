# SqliteDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Sqlite dialect.

```csharp
public class SqliteDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [SqliteDialect](SqliteDialect/SqliteDialect.md)() | The default constructor. |
| virtual [CanUseOffsetFetch](SqliteDialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| virtual [CanUseRowNumber](SqliteDialect/CanUseRowNumber.md) { get; } | Gets a value indicating whether the server supports ROWNUMBER. |
| virtual [CanUseSkipKeyword](SqliteDialect/CanUseSkipKeyword.md) { get; } | Gets a value indicating whether the server supports SKIP keyword (or a variation of it). |
| virtual [CloseQuote](SqliteDialect/CloseQuote.md) { get; } | Gets the close quote character for quoting identifiers. |
| virtual [ConcatOperator](SqliteDialect/ConcatOperator.md) { get; } | Gets the CONCAT operator keyword. |
| virtual [DateFormat](SqliteDialect/DateFormat.md) { get; } | Gets the date format. |
| virtual [DateTimeFormat](SqliteDialect/DateTimeFormat.md) { get; } | Gets the date time format. |
| virtual [IsLikeCaseSensitive](SqliteDialect/IsLikeCaseSensitive.md) { get; } | Gets a value indicating whether the LIKE operator is case sensitive. |
| virtual [MultipleResultsets](SqliteDialect/MultipleResultsets.md) { get; } | Gets a value indicating whether the server supports multiple resultsets. |
| virtual [NeedsBoolWorkaround](SqliteDialect/NeedsBoolWorkaround.md) { get; } | Gets a value indicating whether the server needs a workaround to handle Boolean values false/true. |
| virtual [NeedsExecuteBlockStatement](SqliteDialect/NeedsExecuteBlockStatement.md) { get; } | Gets a value indicating whether the server needs EXECUTE BLOCK statement. |
| virtual [OffsetFetchFormat](SqliteDialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| virtual [OffsetFormat](SqliteDialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| virtual [OpenQuote](SqliteDialect/OpenQuote.md) { get; } | Gets the open quote character for quoting identifiers. |
| virtual [ParameterPrefix](SqliteDialect/ParameterPrefix.md) { get; } | Gets the parameter prefix character. |
| virtual [ScopeIdentityExpression](SqliteDialect/ScopeIdentityExpression.md) { get; } | Gets the SCOPE IDENTITY expression. |
| virtual [ServerType](SqliteDialect/ServerType.md) { get; } | Gets the type of the server. |
| virtual [SkipKeyword](SqliteDialect/SkipKeyword.md) { get; } | Gets the skip keyword. |
| virtual [TakeKeyword](SqliteDialect/TakeKeyword.md) { get; } | Gets the take keyword. |
| virtual [TimeFormat](SqliteDialect/TimeFormat.md) { get; } | Gets the time format. |
| virtual [UseDateTime2](SqliteDialect/UseDateTime2.md) { get; } | Gets a value indicating whether use datetime2 type. |
| virtual [UseReturningIdentity](SqliteDialect/UseReturningIdentity.md) { get; } | Gets a value indicating whether to use returning identity. |
| virtual [UseReturningIntoVar](SqliteDialect/UseReturningIntoVar.md) { get; } | Gets a value indicating whether use returning into variable. |
| virtual [UseRowNum](SqliteDialect/UseRowNum.md) { get; } | Gets a value indicating whether ROWNUM. |
| virtual [UseScopeIdentity](SqliteDialect/UseScopeIdentity.md) { get; } | Gets a value indicating whether to use scope identity. |
| virtual [UseTakeAtEnd](SqliteDialect/UseTakeAtEnd.md) { get; } | Gets a value indicating whether to use TAKE at end. |
| virtual [QuoteColumnAlias](SqliteDialect/QuoteColumnAlias.md)(…) | Quotes the column alias. This usually calls QuoteIdentifier except for Oracle. |
| virtual [QuoteIdentifier](SqliteDialect/QuoteIdentifier.md)(…) | Quotes the identifier. |
| virtual [QuoteUnicodeString](SqliteDialect/QuoteUnicodeString.md)(…) | Quotes the unicode string. |
| [UnionKeyword](SqliteDialect/UnionKeyword.md)(…) | Gets the union keyword for specified union type. |
| static [Instance](SqliteDialect/Instance.md) | The shared instance of SqliteDialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[SqliteDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/SqliteDialect.cs)*