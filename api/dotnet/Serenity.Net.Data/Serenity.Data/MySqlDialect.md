# MySqlDialect class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

MySql dialect.

```csharp
public class MySqlDialect : ISqlDialect
```

## Public Members

| name | description |
| --- | --- |
| [MySqlDialect](MySqlDialect/MySqlDialect.md)() | The default constructor. |
| virtual [CanUseOffsetFetch](MySqlDialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| virtual [CanUseRowNumber](MySqlDialect/CanUseRowNumber.md) { get; } | Gets a value indicating whether the server supports ROWNUMBER. |
| virtual [CanUseSkipKeyword](MySqlDialect/CanUseSkipKeyword.md) { get; } | Gets a value indicating whether the server supports SKIP keyword (or a variation of it). |
| virtual [CloseQuote](MySqlDialect/CloseQuote.md) { get; } | Gets the close quote character for quoting identifiers. |
| virtual [ConcatOperator](MySqlDialect/ConcatOperator.md) { get; } | Gets the CONCAT operator keyword. |
| virtual [DateFormat](MySqlDialect/DateFormat.md) { get; } | Gets the date format. |
| virtual [DateTimeFormat](MySqlDialect/DateTimeFormat.md) { get; } | Gets the date time format. |
| virtual [IsLikeCaseSensitive](MySqlDialect/IsLikeCaseSensitive.md) { get; } | Gets a value indicating whether the LIKE operator is case sensitive. |
| virtual [MultipleResultsets](MySqlDialect/MultipleResultsets.md) { get; } | Gets a value indicating whether the server supports multiple resultsets. |
| virtual [NeedsBoolWorkaround](MySqlDialect/NeedsBoolWorkaround.md) { get; } | Gets a value indicating whether the server needs a workaround to handle Boolean values false/true. |
| virtual [NeedsExecuteBlockStatement](MySqlDialect/NeedsExecuteBlockStatement.md) { get; } | Gets a value indicating whether the server needs EXECUTE BLOCK statement. |
| virtual [OffsetFetchFormat](MySqlDialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| virtual [OffsetFormat](MySqlDialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| virtual [OpenQuote](MySqlDialect/OpenQuote.md) { get; } | Gets the open quote character for quoting identifiers. |
| virtual [ParameterPrefix](MySqlDialect/ParameterPrefix.md) { get; } | Gets the parameter prefix character. |
| virtual [ScopeIdentityExpression](MySqlDialect/ScopeIdentityExpression.md) { get; } | Gets the SCOPE IDENTITY expression. |
| virtual [ServerType](MySqlDialect/ServerType.md) { get; } | Gets the type of the server. |
| virtual [SkipKeyword](MySqlDialect/SkipKeyword.md) { get; } | Gets the skip keyword. |
| virtual [TakeKeyword](MySqlDialect/TakeKeyword.md) { get; } | Gets the take keyword. |
| virtual [TimeFormat](MySqlDialect/TimeFormat.md) { get; } | Gets the time format. |
| virtual [UseDateTime2](MySqlDialect/UseDateTime2.md) { get; } | Gets a value indicating whether use datetime2 type. |
| virtual [UseReturningIdentity](MySqlDialect/UseReturningIdentity.md) { get; } | Gets a value indicating whether to use returning identity. |
| virtual [UseReturningIntoVar](MySqlDialect/UseReturningIntoVar.md) { get; } | Gets a value indicating whether use returning into variable. |
| virtual [UseRowNum](MySqlDialect/UseRowNum.md) { get; } | Gets a value indicating whether ROWNUM. |
| virtual [UseScopeIdentity](MySqlDialect/UseScopeIdentity.md) { get; } | Gets a value indicating whether to use scope identity. |
| virtual [UseTakeAtEnd](MySqlDialect/UseTakeAtEnd.md) { get; } | Gets a value indicating whether to use TAKE at end. |
| virtual [QuoteColumnAlias](MySqlDialect/QuoteColumnAlias.md)(…) | Quotes the column alias. This usually calls QuoteIdentifier except for Oracle. |
| virtual [QuoteIdentifier](MySqlDialect/QuoteIdentifier.md)(…) | Quotes the identifier. |
| virtual [QuoteUnicodeString](MySqlDialect/QuoteUnicodeString.md)(…) | Quotes the unicode string. |
| [UnionKeyword](MySqlDialect/UnionKeyword.md)(…) | Gets the union keyword for specified union type. |
| static readonly [Instance](MySqlDialect/Instance.md) | The shared instance of MySqlDialect. |

## See Also

* interface [ISqlDialect](ISqlDialect.md)
* **Source:** *[MySqlDialect.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Dialects/MySqlDialect.cs)*