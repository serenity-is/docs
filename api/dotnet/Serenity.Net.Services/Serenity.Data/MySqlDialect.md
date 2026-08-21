# MySqlDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

MySql dialect.

```csharp
public class MySqlDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [MySqlDialect](MySqlDialect/MySqlDialect.md)() | The default constructor. |
| virtual [CanUseOffsetFetch](MySqlDialect/CanUseOffsetFetch.md) { get; } |  |
| virtual [CanUseRowNumber](MySqlDialect/CanUseRowNumber.md) { get; } |  |
| virtual [CanUseSkipKeyword](MySqlDialect/CanUseSkipKeyword.md) { get; } |  |
| virtual [CloseQuote](MySqlDialect/CloseQuote.md) { get; } |  |
| virtual [ConcatOperator](MySqlDialect/ConcatOperator.md) { get; } |  |
| virtual [DateFormat](MySqlDialect/DateFormat.md) { get; } |  |
| virtual [DateTimeFormat](MySqlDialect/DateTimeFormat.md) { get; } |  |
| virtual [IsLikeCaseSensitive](MySqlDialect/IsLikeCaseSensitive.md) { get; } |  |
| virtual [MultipleResultsets](MySqlDialect/MultipleResultsets.md) { get; } |  |
| virtual [NeedsBoolWorkaround](MySqlDialect/NeedsBoolWorkaround.md) { get; } |  |
| virtual [NeedsExecuteBlockStatement](MySqlDialect/NeedsExecuteBlockStatement.md) { get; } |  |
| virtual [OffsetFetchFormat](MySqlDialect/OffsetFetchFormat.md) { get; } |  |
| virtual [OffsetFormat](MySqlDialect/OffsetFormat.md) { get; } |  |
| virtual [OpenQuote](MySqlDialect/OpenQuote.md) { get; } |  |
| virtual [ParameterPrefix](MySqlDialect/ParameterPrefix.md) { get; } |  |
| virtual [ScopeIdentityExpression](MySqlDialect/ScopeIdentityExpression.md) { get; } |  |
| virtual [ServerType](MySqlDialect/ServerType.md) { get; } |  |
| virtual [SkipKeyword](MySqlDialect/SkipKeyword.md) { get; } |  |
| virtual [TakeKeyword](MySqlDialect/TakeKeyword.md) { get; } |  |
| virtual [TimeFormat](MySqlDialect/TimeFormat.md) { get; } |  |
| virtual [UseDateTime2](MySqlDialect/UseDateTime2.md) { get; } |  |
| virtual [UseReturningIdentity](MySqlDialect/UseReturningIdentity.md) { get; } |  |
| virtual [UseReturningIntoVar](MySqlDialect/UseReturningIntoVar.md) { get; } |  |
| virtual [UseRowNum](MySqlDialect/UseRowNum.md) { get; } |  |
| virtual [UseScopeIdentity](MySqlDialect/UseScopeIdentity.md) { get; } |  |
| virtual [UseTakeAtEnd](MySqlDialect/UseTakeAtEnd.md) { get; } |  |
| virtual [IsReservedKeyword](MySqlDialect/IsReservedKeyword.md)(…) |  |
| virtual [QuoteColumnAlias](MySqlDialect/QuoteColumnAlias.md)(…) |  |
| virtual [QuoteIdentifier](MySqlDialect/QuoteIdentifier.md)(…) |  |
| virtual [QuoteUnicodeString](MySqlDialect/QuoteUnicodeString.md)(…) |  |
| [UnionKeyword](MySqlDialect/UnionKeyword.md)(…) |  |
| static readonly [Instance](MySqlDialect/Instance.md) | The shared instance of MySqlDialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[MySqlDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Dialects/MySqlDialect.cs)*