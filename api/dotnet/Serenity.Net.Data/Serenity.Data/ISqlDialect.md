# ISqlDialect interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Abstraction for SQL dialect, e.g. syntax for different SQL server types and connection settings.

```csharp
public interface ISqlDialect
```

## Members

| name | description |
| --- | --- |
| [CanUseConcat](ISqlDialect/CanUseConcat.md) { get; } | Gets a value indicating whether the server supports CONCAT. |
| [CanUseOffsetFetch](ISqlDialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| [CanUseRowNumber](ISqlDialect/CanUseRowNumber.md) { get; } | Gets a value indicating whether the server supports ROWNUMBER. |
| [CanUseSkipKeyword](ISqlDialect/CanUseSkipKeyword.md) { get; } | Gets a value indicating whether the server supports SKIP keyword (or a variation of it). |
| [CloseQuote](ISqlDialect/CloseQuote.md) { get; } | Gets the close quote character for quoting identifiers. |
| [ConcatOperator](ISqlDialect/ConcatOperator.md) { get; } | Gets the CONCAT operator keyword. |
| [DateFormat](ISqlDialect/DateFormat.md) { get; } | Gets the date format. |
| [DateTimeFormat](ISqlDialect/DateTimeFormat.md) { get; } | Gets the date time format. |
| [IsLikeCaseSensitive](ISqlDialect/IsLikeCaseSensitive.md) { get; } | Gets a value indicating whether the LIKE operator is case sensitive. |
| [MultipleResultsets](ISqlDialect/MultipleResultsets.md) { get; } | Gets a value indicating whether the server supports multiple resultsets. |
| [NeedsBoolWorkaround](ISqlDialect/NeedsBoolWorkaround.md) { get; } | Gets a value indicating whether the server needs a workaround to handle Boolean values false/true. |
| [NeedsExecuteBlockStatement](ISqlDialect/NeedsExecuteBlockStatement.md) { get; } | Gets a value indicating whether the server needs EXECUTE BLOCK statement. |
| [OffsetFetchFormat](ISqlDialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| [OffsetFormat](ISqlDialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| [OpenQuote](ISqlDialect/OpenQuote.md) { get; } | Gets the open quote character for quoting identifiers. |
| [ParameterPrefix](ISqlDialect/ParameterPrefix.md) { get; } | Gets the parameter prefix character. |
| [ScopeIdentityExpression](ISqlDialect/ScopeIdentityExpression.md) { get; } | Gets the SCOPE IDENTITY expression. |
| [ServerType](ISqlDialect/ServerType.md) { get; } | Gets the type of the server. |
| [SkipKeyword](ISqlDialect/SkipKeyword.md) { get; } | Gets the skip keyword. |
| [TakeKeyword](ISqlDialect/TakeKeyword.md) { get; } | Gets the take keyword. |
| [TimeFormat](ISqlDialect/TimeFormat.md) { get; } | Gets the time format. |
| [UseDateTime2](ISqlDialect/UseDateTime2.md) { get; } | Gets a value indicating whether use datetime2 type. |
| [UseReturningIdentity](ISqlDialect/UseReturningIdentity.md) { get; } | Gets a value indicating whether to use returning identity. |
| [UseReturningIntoVar](ISqlDialect/UseReturningIntoVar.md) { get; } | Gets a value indicating whether use returning into variable. |
| [UseRowNum](ISqlDialect/UseRowNum.md) { get; } | Gets a value indicating whether ROWNUM. |
| [UseScopeIdentity](ISqlDialect/UseScopeIdentity.md) { get; } | Gets a value indicating whether to use scope identity. |
| [UseTakeAtEnd](ISqlDialect/UseTakeAtEnd.md) { get; } | Gets a value indicating whether to use TAKE at end. |
| [QuoteColumnAlias](ISqlDialect/QuoteColumnAlias.md)(…) | Quotes the column alias. This usually calls QuoteIdentifier except for Oracle. |
| [QuoteIdentifier](ISqlDialect/QuoteIdentifier.md)(…) | Quotes the identifier. |
| [QuoteUnicodeString](ISqlDialect/QuoteUnicodeString.md)(…) | Quotes the unicode string. |
| [UnionKeyword](ISqlDialect/UnionKeyword.md)(…) | Gets the union keyword for specified union type. |

## See Also

* **Source:** *[ISqlDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/ISqlDialect.cs)*