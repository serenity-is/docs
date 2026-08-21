# SqlServer2000Dialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

SqlServer 2000 dialect.

```csharp
public class SqlServer2000Dialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [SqlServer2000Dialect](SqlServer2000Dialect/SqlServer2000Dialect.md)() | The default constructor. |
| virtual [CanUseConcat](SqlServer2000Dialect/CanUseConcat.md) { get; } |  |
| virtual [CanUseOffsetFetch](SqlServer2000Dialect/CanUseOffsetFetch.md) { get; } |  |
| virtual [CanUseRowNumber](SqlServer2000Dialect/CanUseRowNumber.md) { get; } |  |
| virtual [CanUseSkipKeyword](SqlServer2000Dialect/CanUseSkipKeyword.md) { get; } |  |
| virtual [CloseQuote](SqlServer2000Dialect/CloseQuote.md) { get; } |  |
| virtual [ConcatOperator](SqlServer2000Dialect/ConcatOperator.md) { get; } |  |
| virtual [DateFormat](SqlServer2000Dialect/DateFormat.md) { get; } |  |
| virtual [DateTimeFormat](SqlServer2000Dialect/DateTimeFormat.md) { get; } |  |
| virtual [IsLikeCaseSensitive](SqlServer2000Dialect/IsLikeCaseSensitive.md) { get; } |  |
| virtual [MultipleResultsets](SqlServer2000Dialect/MultipleResultsets.md) { get; } |  |
| virtual [NeedsBoolWorkaround](SqlServer2000Dialect/NeedsBoolWorkaround.md) { get; } |  |
| virtual [NeedsExecuteBlockStatement](SqlServer2000Dialect/NeedsExecuteBlockStatement.md) { get; } |  |
| virtual [OffsetFetchFormat](SqlServer2000Dialect/OffsetFetchFormat.md) { get; } |  |
| virtual [OffsetFormat](SqlServer2000Dialect/OffsetFormat.md) { get; } |  |
| virtual [OpenQuote](SqlServer2000Dialect/OpenQuote.md) { get; } |  |
| virtual [ParameterPrefix](SqlServer2000Dialect/ParameterPrefix.md) { get; } |  |
| virtual [RequiresBoolConversion](SqlServer2000Dialect/RequiresBoolConversion.md) { get; } | Gets a value indicating whether Boolean values require conversion. |
| virtual [ScopeIdentityExpression](SqlServer2000Dialect/ScopeIdentityExpression.md) { get; } |  |
| virtual [ServerType](SqlServer2000Dialect/ServerType.md) { get; } |  |
| virtual [SkipKeyword](SqlServer2000Dialect/SkipKeyword.md) { get; } |  |
| virtual [TakeKeyword](SqlServer2000Dialect/TakeKeyword.md) { get; } |  |
| virtual [TimeFormat](SqlServer2000Dialect/TimeFormat.md) { get; } |  |
| virtual [UseDateTime2](SqlServer2000Dialect/UseDateTime2.md) { get; } |  |
| virtual [UseReturningIdentity](SqlServer2000Dialect/UseReturningIdentity.md) { get; } |  |
| virtual [UseReturningIntoVar](SqlServer2000Dialect/UseReturningIntoVar.md) { get; } |  |
| virtual [UseRowNum](SqlServer2000Dialect/UseRowNum.md) { get; } |  |
| virtual [UseScopeIdentity](SqlServer2000Dialect/UseScopeIdentity.md) { get; } |  |
| virtual [UseTakeAtEnd](SqlServer2000Dialect/UseTakeAtEnd.md) { get; } |  |
| [IsReservedKeyword](SqlServer2000Dialect/IsReservedKeyword.md)(…) |  |
| virtual [QuoteColumnAlias](SqlServer2000Dialect/QuoteColumnAlias.md)(…) |  |
| virtual [QuoteIdentifier](SqlServer2000Dialect/QuoteIdentifier.md)(…) |  |
| virtual [QuoteUnicodeString](SqlServer2000Dialect/QuoteUnicodeString.md)(…) |  |
| [UnionKeyword](SqlServer2000Dialect/UnionKeyword.md)(…) |  |
| static readonly [Instance](SqlServer2000Dialect/Instance.md) | The shared instance of SqlServer2000 dialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[SqlServer2000Dialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Dialects/SqlServer2000Dialect.cs)*