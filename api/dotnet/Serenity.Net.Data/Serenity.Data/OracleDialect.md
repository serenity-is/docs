# OracleDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Oracle dialect

```csharp
public class OracleDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [OracleDialect](OracleDialect/OracleDialect.md)() | The default constructor. |
| virtual [CanUseOffsetFetch](OracleDialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| virtual [CanUseRowNumber](OracleDialect/CanUseRowNumber.md) { get; } | Gets a value indicating whether the server supports ROWNUMBER. |
| virtual [CanUseSkipKeyword](OracleDialect/CanUseSkipKeyword.md) { get; } | Gets a value indicating whether the server supports SKIP keyword (or a variation of it). |
| virtual [CloseQuote](OracleDialect/CloseQuote.md) { get; } | Gets the close quote character for quoting identifiers. |
| virtual [ConcatOperator](OracleDialect/ConcatOperator.md) { get; } | Gets the CONCAT operator keyword. |
| virtual [DateFormat](OracleDialect/DateFormat.md) { get; } | Gets the date format. |
| virtual [DateTimeFormat](OracleDialect/DateTimeFormat.md) { get; } | Gets the date time format. |
| virtual [IsLikeCaseSensitive](OracleDialect/IsLikeCaseSensitive.md) { get; } | Gets a value indicating whether the LIKE operator is case sensitive. |
| virtual [MultipleResultsets](OracleDialect/MultipleResultsets.md) { get; } | Gets a value indicating whether the server supports multiple resultsets. |
| virtual [NeedsBoolWorkaround](OracleDialect/NeedsBoolWorkaround.md) { get; } | Gets a value indicating whether the server needs a workaround to handle Boolean values false/true. |
| virtual [NeedsExecuteBlockStatement](OracleDialect/NeedsExecuteBlockStatement.md) { get; } | Gets a value indicating whether the server needs EXECUTE BLOCK statement. |
| virtual [OffsetFetchFormat](OracleDialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| virtual [OffsetFormat](OracleDialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| virtual [OpenQuote](OracleDialect/OpenQuote.md) { get; } | Gets the open quote character for quoting identifiers. |
| virtual [ParameterPrefix](OracleDialect/ParameterPrefix.md) { get; } | Gets the parameter prefix character. |
| virtual [ScopeIdentityExpression](OracleDialect/ScopeIdentityExpression.md) { get; } | Gets the SCOPE IDENTITY expression. |
| virtual [ServerType](OracleDialect/ServerType.md) { get; } | Gets the type of the server. |
| virtual [SkipKeyword](OracleDialect/SkipKeyword.md) { get; } | Gets the skip keyword. |
| virtual [TakeKeyword](OracleDialect/TakeKeyword.md) { get; } | Gets the take keyword. |
| virtual [TimeFormat](OracleDialect/TimeFormat.md) { get; } | Gets the time format. |
| virtual [UseDateTime2](OracleDialect/UseDateTime2.md) { get; } | Gets a value indicating whether use datetime2 type. |
| virtual [UseReturningIdentity](OracleDialect/UseReturningIdentity.md) { get; } | Gets a value indicating whether to use returning identity. |
| virtual [UseReturningIntoVar](OracleDialect/UseReturningIntoVar.md) { get; } | Gets a value indicating whether use returning into variable. |
| virtual [UseRowNum](OracleDialect/UseRowNum.md) { get; } | Gets a value indicating whether ROWNUM. |
| virtual [UseScopeIdentity](OracleDialect/UseScopeIdentity.md) { get; } | Gets a value indicating whether to use scope identity. |
| virtual [UseTakeAtEnd](OracleDialect/UseTakeAtEnd.md) { get; } | Gets a value indicating whether to use TAKE at end. |
| virtual [QuoteColumnAlias](OracleDialect/QuoteColumnAlias.md)(…) | Quotes the column alias. This usually calls QuoteIdentifier except for Oracle. |
| virtual [QuoteIdentifier](OracleDialect/QuoteIdentifier.md)(…) | Quotes the identifier. |
| virtual [QuoteUnicodeString](OracleDialect/QuoteUnicodeString.md)(…) | Quotes the unicode string. |
| [UnionKeyword](OracleDialect/UnionKeyword.md)(…) | Gets the union keyword for specified union type. |
| static readonly [Instance](OracleDialect/Instance.md) | The shared instance of OracleDialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[OracleDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/OracleDialect.cs)*