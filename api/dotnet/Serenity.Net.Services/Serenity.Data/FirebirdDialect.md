# FirebirdDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

SQL dialect for Firebird.

```csharp
public class FirebirdDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [FirebirdDialect](FirebirdDialect/FirebirdDialect.md)() | The default constructor. |
| static readonly [Instance](FirebirdDialect/Instance.md) | The shared instance of FirebirdDialect. |
| virtual [CanUseConcat](FirebirdDialect/CanUseConcat.md) { get; } |  |
| virtual [CanUseOffsetFetch](FirebirdDialect/CanUseOffsetFetch.md) { get; } |  |
| virtual [CanUseRowNumber](FirebirdDialect/CanUseRowNumber.md) { get; } |  |
| virtual [CanUseSkipKeyword](FirebirdDialect/CanUseSkipKeyword.md) { get; } |  |
| virtual [CloseQuote](FirebirdDialect/CloseQuote.md) { get; } |  |
| virtual [ConcatOperator](FirebirdDialect/ConcatOperator.md) { get; } |  |
| virtual [DateFormat](FirebirdDialect/DateFormat.md) { get; } |  |
| virtual [DateTimeFormat](FirebirdDialect/DateTimeFormat.md) { get; } |  |
| virtual [IsLikeCaseSensitive](FirebirdDialect/IsLikeCaseSensitive.md) { get; } |  |
| virtual [MultipleResultsets](FirebirdDialect/MultipleResultsets.md) { get; } |  |
| virtual [NeedsBoolWorkaround](FirebirdDialect/NeedsBoolWorkaround.md) { get; } |  |
| virtual [NeedsExecuteBlockStatement](FirebirdDialect/NeedsExecuteBlockStatement.md) { get; } |  |
| virtual [OffsetFetchFormat](FirebirdDialect/OffsetFetchFormat.md) { get; } |  |
| virtual [OffsetFormat](FirebirdDialect/OffsetFormat.md) { get; } |  |
| virtual [OpenQuote](FirebirdDialect/OpenQuote.md) { get; } |  |
| virtual [ParameterPrefix](FirebirdDialect/ParameterPrefix.md) { get; } |  |
| virtual [ScopeIdentityExpression](FirebirdDialect/ScopeIdentityExpression.md) { get; } |  |
| virtual [ServerType](FirebirdDialect/ServerType.md) { get; } |  |
| virtual [SkipKeyword](FirebirdDialect/SkipKeyword.md) { get; } |  |
| virtual [TakeKeyword](FirebirdDialect/TakeKeyword.md) { get; } |  |
| virtual [TimeFormat](FirebirdDialect/TimeFormat.md) { get; } |  |
| virtual [UseDateTime2](FirebirdDialect/UseDateTime2.md) { get; } |  |
| virtual [UseReturningIdentity](FirebirdDialect/UseReturningIdentity.md) { get; } |  |
| virtual [UseReturningIntoVar](FirebirdDialect/UseReturningIntoVar.md) { get; } |  |
| virtual [UseRowNum](FirebirdDialect/UseRowNum.md) { get; } |  |
| virtual [UseScopeIdentity](FirebirdDialect/UseScopeIdentity.md) { get; } |  |
| virtual [UseTakeAtEnd](FirebirdDialect/UseTakeAtEnd.md) { get; } |  |
| virtual [IsReservedKeyword](FirebirdDialect/IsReservedKeyword.md)(…) |  |
| virtual [QuoteColumnAlias](FirebirdDialect/QuoteColumnAlias.md)(…) |  |
| virtual [QuoteIdentifier](FirebirdDialect/QuoteIdentifier.md)(…) |  |
| virtual [QuoteUnicodeString](FirebirdDialect/QuoteUnicodeString.md)(…) |  |
| [UnionKeyword](FirebirdDialect/UnionKeyword.md)(…) |  |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[FirebirdDialect.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Data/Dialects/FirebirdDialect.cs)*