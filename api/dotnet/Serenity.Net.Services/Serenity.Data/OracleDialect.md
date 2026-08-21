# OracleDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

SQL dialect for Oracle.

```csharp
public class OracleDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [OracleDialect](OracleDialect/OracleDialect.md)() | The default constructor. |
| virtual [CanUseOffsetFetch](OracleDialect/CanUseOffsetFetch.md) { get; } |  |
| virtual [CanUseRowNumber](OracleDialect/CanUseRowNumber.md) { get; } |  |
| virtual [CanUseSkipKeyword](OracleDialect/CanUseSkipKeyword.md) { get; } |  |
| virtual [CloseQuote](OracleDialect/CloseQuote.md) { get; } |  |
| virtual [ConcatOperator](OracleDialect/ConcatOperator.md) { get; } |  |
| virtual [DateFormat](OracleDialect/DateFormat.md) { get; } |  |
| virtual [DateTimeFormat](OracleDialect/DateTimeFormat.md) { get; } |  |
| virtual [IsLikeCaseSensitive](OracleDialect/IsLikeCaseSensitive.md) { get; } |  |
| virtual [MultipleResultsets](OracleDialect/MultipleResultsets.md) { get; } |  |
| virtual [NeedsBoolWorkaround](OracleDialect/NeedsBoolWorkaround.md) { get; } |  |
| virtual [NeedsExecuteBlockStatement](OracleDialect/NeedsExecuteBlockStatement.md) { get; } |  |
| virtual [OffsetFetchFormat](OracleDialect/OffsetFetchFormat.md) { get; } |  |
| virtual [OffsetFormat](OracleDialect/OffsetFormat.md) { get; } |  |
| virtual [OpenQuote](OracleDialect/OpenQuote.md) { get; } |  |
| virtual [ParameterPrefix](OracleDialect/ParameterPrefix.md) { get; } |  |
| virtual [ScopeIdentityExpression](OracleDialect/ScopeIdentityExpression.md) { get; } |  |
| virtual [ServerType](OracleDialect/ServerType.md) { get; } |  |
| virtual [SkipKeyword](OracleDialect/SkipKeyword.md) { get; } |  |
| virtual [TakeKeyword](OracleDialect/TakeKeyword.md) { get; } |  |
| virtual [TimeFormat](OracleDialect/TimeFormat.md) { get; } |  |
| virtual [UseDateTime2](OracleDialect/UseDateTime2.md) { get; } |  |
| virtual [UseReturningIdentity](OracleDialect/UseReturningIdentity.md) { get; } |  |
| virtual [UseReturningIntoVar](OracleDialect/UseReturningIntoVar.md) { get; } |  |
| virtual [UseRowNum](OracleDialect/UseRowNum.md) { get; } |  |
| virtual [UseScopeIdentity](OracleDialect/UseScopeIdentity.md) { get; } |  |
| virtual [UseTakeAtEnd](OracleDialect/UseTakeAtEnd.md) { get; } |  |
| virtual [IsReservedKeyword](OracleDialect/IsReservedKeyword.md)(…) |  |
| virtual [QuoteColumnAlias](OracleDialect/QuoteColumnAlias.md)(…) |  |
| virtual [QuoteIdentifier](OracleDialect/QuoteIdentifier.md)(…) |  |
| virtual [QuoteUnicodeString](OracleDialect/QuoteUnicodeString.md)(…) |  |
| [UnionKeyword](OracleDialect/UnionKeyword.md)(…) |  |
| static readonly [Instance](OracleDialect/Instance.md) | The shared instance of OracleDialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[OracleDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Dialects/OracleDialect.cs)*