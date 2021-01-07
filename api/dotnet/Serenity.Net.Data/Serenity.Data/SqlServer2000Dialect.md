# SqlServer2000Dialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

SqlServer 2000 dialect.

```csharp
public class SqlServer2000Dialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [SqlServer2000Dialect](SqlServer2000Dialect/SqlServer2000Dialect.md)() | The default constructor. |
| virtual [CanUseOffsetFetch](SqlServer2000Dialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| virtual [CanUseRowNumber](SqlServer2000Dialect/CanUseRowNumber.md) { get; } | Gets a value indicating whether the server supports ROWNUMBER. |
| virtual [CanUseSkipKeyword](SqlServer2000Dialect/CanUseSkipKeyword.md) { get; } | Gets a value indicating whether the server supports SKIP keyword (or a variation of it). |
| virtual [CloseQuote](SqlServer2000Dialect/CloseQuote.md) { get; } | Gets the close quote character for quoting identifiers. |
| virtual [ConcatOperator](SqlServer2000Dialect/ConcatOperator.md) { get; } | Gets the CONCAT operator keyword. |
| virtual [DateFormat](SqlServer2000Dialect/DateFormat.md) { get; } | Gets the date format. |
| virtual [DateTimeFormat](SqlServer2000Dialect/DateTimeFormat.md) { get; } | Gets the date time format. |
| virtual [IsLikeCaseSensitive](SqlServer2000Dialect/IsLikeCaseSensitive.md) { get; } | Gets a value indicating whether the LIKE operator is case sensitive. |
| virtual [MultipleResultsets](SqlServer2000Dialect/MultipleResultsets.md) { get; } | Gets a value indicating whether the server supports multiple resultsets. |
| virtual [NeedsBoolWorkaround](SqlServer2000Dialect/NeedsBoolWorkaround.md) { get; } | Gets a value indicating whether the server needs a workaround to handle Boolean values false/true. |
| virtual [NeedsExecuteBlockStatement](SqlServer2000Dialect/NeedsExecuteBlockStatement.md) { get; } | Gets a value indicating whether the server needs EXECUTE BLOCK statement. |
| virtual [OffsetFetchFormat](SqlServer2000Dialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| virtual [OffsetFormat](SqlServer2000Dialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| virtual [OpenQuote](SqlServer2000Dialect/OpenQuote.md) { get; } | Gets the open quote character for quoting identifiers. |
| virtual [ParameterPrefix](SqlServer2000Dialect/ParameterPrefix.md) { get; } | Gets the parameter prefix character. |
| virtual [RequiresBoolConversion](SqlServer2000Dialect/RequiresBoolConversion.md) { get; } | Gets a value indicating whether [requires bool conversion]. |
| virtual [ScopeIdentityExpression](SqlServer2000Dialect/ScopeIdentityExpression.md) { get; } | Gets the SCOPE IDENTITY expression. |
| virtual [ServerType](SqlServer2000Dialect/ServerType.md) { get; } | Gets the type of the server. |
| virtual [SkipKeyword](SqlServer2000Dialect/SkipKeyword.md) { get; } | Gets the skip keyword. |
| virtual [TakeKeyword](SqlServer2000Dialect/TakeKeyword.md) { get; } | Gets the take keyword. |
| virtual [TimeFormat](SqlServer2000Dialect/TimeFormat.md) { get; } | Gets the time format. |
| virtual [UseDateTime2](SqlServer2000Dialect/UseDateTime2.md) { get; } | Gets a value indicating whether use datetime2 type. |
| virtual [UseReturningIdentity](SqlServer2000Dialect/UseReturningIdentity.md) { get; } | Gets a value indicating whether to use returning identity. |
| virtual [UseReturningIntoVar](SqlServer2000Dialect/UseReturningIntoVar.md) { get; } | Gets a value indicating whether use returning into variable. |
| virtual [UseRowNum](SqlServer2000Dialect/UseRowNum.md) { get; } | Gets a value indicating whether ROWNUM. |
| virtual [UseScopeIdentity](SqlServer2000Dialect/UseScopeIdentity.md) { get; } | Gets a value indicating whether to use scope identity. |
| virtual [UseTakeAtEnd](SqlServer2000Dialect/UseTakeAtEnd.md) { get; } | Gets a value indicating whether to use TAKE at end. |
| virtual [QuoteColumnAlias](SqlServer2000Dialect/QuoteColumnAlias.md)(…) | Quotes the column alias. This usually calls QuoteIdentifier except for Oracle. |
| virtual [QuoteIdentifier](SqlServer2000Dialect/QuoteIdentifier.md)(…) | Quotes the identifier. |
| virtual [QuoteUnicodeString](SqlServer2000Dialect/QuoteUnicodeString.md)(…) | Quotes the unicode string. |
| [UnionKeyword](SqlServer2000Dialect/UnionKeyword.md)(…) | Gets the union keyword for specified union type. |
| static readonly [Instance](SqlServer2000Dialect/Instance.md) | The shared instance of SqlServer2000 dialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[SqlServer2000Dialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/SqlServer2000Dialect.cs)*