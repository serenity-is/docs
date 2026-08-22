# SqliteDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Sqlite dialect.

```csharp
public class SqliteDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [SqliteDialect](SqliteDialect/SqliteDialect.md)() | The default constructor. |
| virtual [CanUseConcat](SqliteDialect/CanUseConcat.md) { get; } |  |
| virtual [CanUseOffsetFetch](SqliteDialect/CanUseOffsetFetch.md) { get; } |  |
| virtual [CanUseRowNumber](SqliteDialect/CanUseRowNumber.md) { get; } |  |
| virtual [CanUseSkipKeyword](SqliteDialect/CanUseSkipKeyword.md) { get; } |  |
| virtual [CloseQuote](SqliteDialect/CloseQuote.md) { get; } |  |
| virtual [ConcatOperator](SqliteDialect/ConcatOperator.md) { get; } |  |
| virtual [DateFormat](SqliteDialect/DateFormat.md) { get; } |  |
| virtual [DateTimeFormat](SqliteDialect/DateTimeFormat.md) { get; } |  |
| virtual [IsLikeCaseSensitive](SqliteDialect/IsLikeCaseSensitive.md) { get; } |  |
| virtual [MultipleResultsets](SqliteDialect/MultipleResultsets.md) { get; } |  |
| virtual [NeedsBoolWorkaround](SqliteDialect/NeedsBoolWorkaround.md) { get; } |  |
| virtual [NeedsExecuteBlockStatement](SqliteDialect/NeedsExecuteBlockStatement.md) { get; } |  |
| virtual [OffsetFetchFormat](SqliteDialect/OffsetFetchFormat.md) { get; } |  |
| virtual [OffsetFormat](SqliteDialect/OffsetFormat.md) { get; } |  |
| virtual [OpenQuote](SqliteDialect/OpenQuote.md) { get; } |  |
| virtual [ParameterPrefix](SqliteDialect/ParameterPrefix.md) { get; } |  |
| virtual [ScopeIdentityExpression](SqliteDialect/ScopeIdentityExpression.md) { get; } |  |
| virtual [ServerType](SqliteDialect/ServerType.md) { get; } |  |
| virtual [SkipKeyword](SqliteDialect/SkipKeyword.md) { get; } |  |
| virtual [TakeKeyword](SqliteDialect/TakeKeyword.md) { get; } |  |
| virtual [TimeFormat](SqliteDialect/TimeFormat.md) { get; } |  |
| virtual [UseDateTime2](SqliteDialect/UseDateTime2.md) { get; } |  |
| virtual [UseReturningIdentity](SqliteDialect/UseReturningIdentity.md) { get; } |  |
| virtual [UseReturningIntoVar](SqliteDialect/UseReturningIntoVar.md) { get; } |  |
| virtual [UseRowNum](SqliteDialect/UseRowNum.md) { get; } |  |
| virtual [UseScopeIdentity](SqliteDialect/UseScopeIdentity.md) { get; } |  |
| virtual [UseTakeAtEnd](SqliteDialect/UseTakeAtEnd.md) { get; } |  |
| virtual [IsReservedKeyword](SqliteDialect/IsReservedKeyword.md)(…) |  |
| virtual [QuoteColumnAlias](SqliteDialect/QuoteColumnAlias.md)(…) |  |
| virtual [QuoteIdentifier](SqliteDialect/QuoteIdentifier.md)(…) |  |
| virtual [QuoteUnicodeString](SqliteDialect/QuoteUnicodeString.md)(…) |  |
| [UnionKeyword](SqliteDialect/UnionKeyword.md)(…) |  |
| static [Instance](SqliteDialect/Instance.md) | The shared instance of SqliteDialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[SqliteDialect.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Dialects/SqliteDialect.cs)*