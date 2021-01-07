# FirebirdDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Firebird dialect

```csharp
public class FirebirdDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [FirebirdDialect](FirebirdDialect/FirebirdDialect.md)() | The default constructor. |
| static readonly [Instance](FirebirdDialect/Instance.md) | The shared instance of FirebirdDialect. |
| virtual [CanUseOffsetFetch](FirebirdDialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| virtual [CanUseRowNumber](FirebirdDialect/CanUseRowNumber.md) { get; } | Gets a value indicating whether the server supports ROWNUMBER. |
| virtual [CanUseSkipKeyword](FirebirdDialect/CanUseSkipKeyword.md) { get; } | Gets a value indicating whether the server supports SKIP keyword (or a variation of it). |
| virtual [CloseQuote](FirebirdDialect/CloseQuote.md) { get; } | Gets the close quote character for quoting identifiers. |
| virtual [ConcatOperator](FirebirdDialect/ConcatOperator.md) { get; } | Gets the CONCAT operator keyword. |
| virtual [DateFormat](FirebirdDialect/DateFormat.md) { get; } | Gets the date format. |
| virtual [DateTimeFormat](FirebirdDialect/DateTimeFormat.md) { get; } | Gets the date time format. |
| virtual [IsLikeCaseSensitive](FirebirdDialect/IsLikeCaseSensitive.md) { get; } | Gets a value indicating whether the LIKE operator is case sensitive. |
| virtual [MultipleResultsets](FirebirdDialect/MultipleResultsets.md) { get; } | Gets a value indicating whether the server supports multiple resultsets. |
| virtual [NeedsBoolWorkaround](FirebirdDialect/NeedsBoolWorkaround.md) { get; } | Gets a value indicating whether the server needs a workaround to handle Boolean values false/true. |
| virtual [NeedsExecuteBlockStatement](FirebirdDialect/NeedsExecuteBlockStatement.md) { get; } | Gets a value indicating whether the server needs EXECUTE BLOCK statement. |
| virtual [OffsetFetchFormat](FirebirdDialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| virtual [OffsetFormat](FirebirdDialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| virtual [OpenQuote](FirebirdDialect/OpenQuote.md) { get; } | Gets the open quote character for quoting identifiers. |
| virtual [ParameterPrefix](FirebirdDialect/ParameterPrefix.md) { get; } | Gets the parameter prefix character. |
| virtual [ScopeIdentityExpression](FirebirdDialect/ScopeIdentityExpression.md) { get; } | Gets the SCOPE IDENTITY expression. |
| virtual [ServerType](FirebirdDialect/ServerType.md) { get; } | Gets the type of the server. |
| virtual [SkipKeyword](FirebirdDialect/SkipKeyword.md) { get; } | Gets the skip keyword. |
| virtual [TakeKeyword](FirebirdDialect/TakeKeyword.md) { get; } | Gets the take keyword. |
| virtual [TimeFormat](FirebirdDialect/TimeFormat.md) { get; } | Gets the time format. |
| virtual [UseDateTime2](FirebirdDialect/UseDateTime2.md) { get; } | Gets a value indicating whether use datetime2 type. |
| virtual [UseReturningIdentity](FirebirdDialect/UseReturningIdentity.md) { get; } | Gets a value indicating whether to use returning identity. |
| virtual [UseReturningIntoVar](FirebirdDialect/UseReturningIntoVar.md) { get; } | Gets a value indicating whether use returning into variable. |
| virtual [UseRowNum](FirebirdDialect/UseRowNum.md) { get; } | Gets a value indicating whether ROWNUM. |
| virtual [UseScopeIdentity](FirebirdDialect/UseScopeIdentity.md) { get; } | Gets a value indicating whether to use scope identity. |
| virtual [UseTakeAtEnd](FirebirdDialect/UseTakeAtEnd.md) { get; } | Gets a value indicating whether to use TAKE at end. |
| virtual [QuoteColumnAlias](FirebirdDialect/QuoteColumnAlias.md)(…) | Quotes the column alias. This usually calls QuoteIdentifier except for Oracle. |
| virtual [QuoteIdentifier](FirebirdDialect/QuoteIdentifier.md)(…) | Quotes the identifier. |
| virtual [QuoteUnicodeString](FirebirdDialect/QuoteUnicodeString.md)(…) | Quotes the unicode string. |
| [UnionKeyword](FirebirdDialect/UnionKeyword.md)(…) | Gets the union keyword for specified union type. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[FirebirdDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/FirebirdDialect.cs)*