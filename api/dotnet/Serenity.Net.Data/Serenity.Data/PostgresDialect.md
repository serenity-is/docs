# PostgresDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Postgres dialect

```csharp
public class PostgresDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [PostgresDialect](PostgresDialect/PostgresDialect.md)() | The default constructor. |
| virtual [CanUseOffsetFetch](PostgresDialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| virtual [CanUseRowNumber](PostgresDialect/CanUseRowNumber.md) { get; } | Gets a value indicating whether the server supports ROWNUMBER. |
| virtual [CanUseSkipKeyword](PostgresDialect/CanUseSkipKeyword.md) { get; } | Gets a value indicating whether the server supports SKIP keyword (or a variation of it). |
| virtual [CloseQuote](PostgresDialect/CloseQuote.md) { get; } | Gets the close quote character for quoting identifiers. |
| virtual [ConcatOperator](PostgresDialect/ConcatOperator.md) { get; } | Gets the CONCAT operator keyword. |
| virtual [DateFormat](PostgresDialect/DateFormat.md) { get; } | Gets the date format. |
| virtual [DateTimeFormat](PostgresDialect/DateTimeFormat.md) { get; } | Gets the date time format. |
| virtual [IsLikeCaseSensitive](PostgresDialect/IsLikeCaseSensitive.md) { get; } | Gets a value indicating whether the LIKE operator is case sensitive. |
| virtual [MultipleResultsets](PostgresDialect/MultipleResultsets.md) { get; } | Gets a value indicating whether the server supports multiple resultsets. |
| virtual [NeedsBoolWorkaround](PostgresDialect/NeedsBoolWorkaround.md) { get; } | Gets a value indicating whether the server needs a workaround to handle Boolean values false/true. |
| virtual [NeedsExecuteBlockStatement](PostgresDialect/NeedsExecuteBlockStatement.md) { get; } | Gets a value indicating whether the server needs EXECUTE BLOCK statement. |
| virtual [OffsetFetchFormat](PostgresDialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| virtual [OffsetFormat](PostgresDialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| virtual [OpenQuote](PostgresDialect/OpenQuote.md) { get; } | Gets the open quote character for quoting identifiers. |
| virtual [ParameterPrefix](PostgresDialect/ParameterPrefix.md) { get; } | Gets the parameter prefix character. |
| virtual [ScopeIdentityExpression](PostgresDialect/ScopeIdentityExpression.md) { get; } | Gets the SCOPE IDENTITY expression. |
| virtual [ServerType](PostgresDialect/ServerType.md) { get; } | Gets the type of the server. |
| virtual [SkipKeyword](PostgresDialect/SkipKeyword.md) { get; } | Gets the skip keyword. |
| virtual [TakeKeyword](PostgresDialect/TakeKeyword.md) { get; } | Gets the take keyword. |
| virtual [TimeFormat](PostgresDialect/TimeFormat.md) { get; } | Gets the time format. |
| virtual [UseDateTime2](PostgresDialect/UseDateTime2.md) { get; } | Gets a value indicating whether use datetime2 type. |
| virtual [UseReturningIdentity](PostgresDialect/UseReturningIdentity.md) { get; } | Gets a value indicating whether to use returning identity. |
| virtual [UseReturningIntoVar](PostgresDialect/UseReturningIntoVar.md) { get; } | Gets a value indicating whether use returning into variable. |
| virtual [UseRowNum](PostgresDialect/UseRowNum.md) { get; } | Gets a value indicating whether ROWNUM. |
| virtual [UseScopeIdentity](PostgresDialect/UseScopeIdentity.md) { get; } | Gets a value indicating whether to use scope identity. |
| virtual [UseTakeAtEnd](PostgresDialect/UseTakeAtEnd.md) { get; } | Gets a value indicating whether to use TAKE at end. |
| virtual [QuoteColumnAlias](PostgresDialect/QuoteColumnAlias.md)(…) | Quotes the column alias. This usually calls QuoteIdentifier except for Oracle. |
| virtual [QuoteIdentifier](PostgresDialect/QuoteIdentifier.md)(…) | Quotes the identifier. |
| virtual [QuoteUnicodeString](PostgresDialect/QuoteUnicodeString.md)(…) | Quotes the unicode string. |
| [UnionKeyword](PostgresDialect/UnionKeyword.md)(…) | Gets the union keyword for specified union type. |
| static readonly [Instance](PostgresDialect/Instance.md) | The shared instance of PostgresDialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[PostgresDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/PostgresDialect.cs)*