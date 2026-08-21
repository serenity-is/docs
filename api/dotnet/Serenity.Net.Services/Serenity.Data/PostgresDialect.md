# PostgresDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

SQL dialect for Postgres.

```csharp
public class PostgresDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [PostgresDialect](PostgresDialect/PostgresDialect.md)() | The default constructor. |
| virtual [CanUseOffsetFetch](PostgresDialect/CanUseOffsetFetch.md) { get; } |  |
| virtual [CanUseRowNumber](PostgresDialect/CanUseRowNumber.md) { get; } |  |
| virtual [CanUseSkipKeyword](PostgresDialect/CanUseSkipKeyword.md) { get; } |  |
| virtual [CloseQuote](PostgresDialect/CloseQuote.md) { get; } |  |
| virtual [ConcatOperator](PostgresDialect/ConcatOperator.md) { get; } |  |
| virtual [DateFormat](PostgresDialect/DateFormat.md) { get; } |  |
| virtual [DateTimeFormat](PostgresDialect/DateTimeFormat.md) { get; } |  |
| virtual [IsLikeCaseSensitive](PostgresDialect/IsLikeCaseSensitive.md) { get; } |  |
| virtual [MultipleResultsets](PostgresDialect/MultipleResultsets.md) { get; } |  |
| virtual [NeedsBoolWorkaround](PostgresDialect/NeedsBoolWorkaround.md) { get; } |  |
| virtual [NeedsExecuteBlockStatement](PostgresDialect/NeedsExecuteBlockStatement.md) { get; } |  |
| virtual [OffsetFetchFormat](PostgresDialect/OffsetFetchFormat.md) { get; } |  |
| virtual [OffsetFormat](PostgresDialect/OffsetFormat.md) { get; } |  |
| virtual [OpenQuote](PostgresDialect/OpenQuote.md) { get; } |  |
| virtual [ParameterPrefix](PostgresDialect/ParameterPrefix.md) { get; } |  |
| virtual [ScopeIdentityExpression](PostgresDialect/ScopeIdentityExpression.md) { get; } |  |
| virtual [ServerType](PostgresDialect/ServerType.md) { get; } |  |
| virtual [SkipKeyword](PostgresDialect/SkipKeyword.md) { get; } |  |
| virtual [TakeKeyword](PostgresDialect/TakeKeyword.md) { get; } |  |
| virtual [TimeFormat](PostgresDialect/TimeFormat.md) { get; } |  |
| virtual [UseDateTime2](PostgresDialect/UseDateTime2.md) { get; } |  |
| virtual [UseReturningIdentity](PostgresDialect/UseReturningIdentity.md) { get; } |  |
| virtual [UseReturningIntoVar](PostgresDialect/UseReturningIntoVar.md) { get; } |  |
| virtual [UseRowNum](PostgresDialect/UseRowNum.md) { get; } |  |
| virtual [UseScopeIdentity](PostgresDialect/UseScopeIdentity.md) { get; } |  |
| virtual [UseTakeAtEnd](PostgresDialect/UseTakeAtEnd.md) { get; } |  |
| virtual [IsReservedKeyword](PostgresDialect/IsReservedKeyword.md)(…) |  |
| virtual [QuoteColumnAlias](PostgresDialect/QuoteColumnAlias.md)(…) |  |
| virtual [QuoteIdentifier](PostgresDialect/QuoteIdentifier.md)(…) |  |
| virtual [QuoteUnicodeString](PostgresDialect/QuoteUnicodeString.md)(…) |  |
| [UnionKeyword](PostgresDialect/UnionKeyword.md)(…) |  |
| static readonly [Instance](PostgresDialect/Instance.md) | The shared instance of PostgresDialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[PostgresDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Dialects/PostgresDialect.cs)*