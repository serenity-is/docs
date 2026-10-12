# ISqlDialect interface
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Abstraction for SQL dialect, e.g. syntax for different SQL server types and connection settings.

```csharp
public interface ISqlDialect
```

## Members

| name | description |
| --- | --- |
| [AutoQuotedIdentifiers](ISqlDialect/AutoQuotedIdentifiers.md) { get; } | Gets a value indicating whether to automatically quote identifiers. Default is null, e.g. SqlSettings.AutoQuotedIdentifiers is used, which itself is false by default, but usually set to true in applications. |
| [CanUseConcat](ISqlDialect/CanUseConcat.md) { get; } | Gets a value indicating whether the server supports the CONCAT() function (used by `ConcatAttribute` to decide between `CONCAT(...)` and an infix operator). This does not imply [`ConcatOperator`](./ISqlDialect/ConcatOperator.md) is available: e.g. MySQL supports `CONCAT()` but has no infix concatenation operator (`||` is logical OR there unless PIPES_AS_CONCAT mode is on). |
| [CanUseOffsetFetch](ISqlDialect/CanUseOffsetFetch.md) { get; } | Gets a value indicating whether the server supports OFFSET FETCH. |
| [CanUseRowNumber](ISqlDialect/CanUseRowNumber.md) { get; } | Gets a value indicating whether the server supports ROWNUMBER. |
| [CanUseSkipKeyword](ISqlDialect/CanUseSkipKeyword.md) { get; } | Gets a value indicating whether the server supports SKIP keyword (or a variation of it). |
| [CloseQuote](ISqlDialect/CloseQuote.md) { get; } | Gets the close quote character for quoting identifiers. |
| [Comparer](ISqlDialect/Comparer.md) { get; } | Gets the comparer used to compare string field values for this connection, or null to fall back to [`DefaultComparer`](./SqlSettings/DefaultComparer.md). Dialects that support a per-connection comparer override this and [`WithComparer`](./ISqlDialect/WithComparer.md). |
| [ConcatOperator](ISqlDialect/ConcatOperator.md) { get; } | Gets the CONCAT operator keyword. |
| [DateFormat](ISqlDialect/DateFormat.md) { get; } | Gets the date format. |
| [DateTimeFormat](ISqlDialect/DateTimeFormat.md) { get; } | Gets the date time format. |
| [IsLikeCaseSensitive](ISqlDialect/IsLikeCaseSensitive.md) { get; } | Gets a value indicating whether the LIKE operator is case sensitive. |
| [MultipleResultsets](ISqlDialect/MultipleResultsets.md) { get; } | Gets a value indicating whether the server supports multiple resultsets. |
| [NeedsBoolWorkaround](ISqlDialect/NeedsBoolWorkaround.md) { get; } | Gets a value indicating whether the server needs a workaround to handle Boolean values false/true. |
| [NeedsExecuteBlockStatement](ISqlDialect/NeedsExecuteBlockStatement.md) { get; } | Gets a value indicating whether the server needs EXECUTE BLOCK statement. |
| [OffsetFetchFormat](ISqlDialect/OffsetFetchFormat.md) { get; } | Gets the format for OFFSET FETCH statements. |
| [OffsetFormat](ISqlDialect/OffsetFormat.md) { get; } | Gets the format for OFFSET only statements. |
| [OpenQuote](ISqlDialect/OpenQuote.md) { get; } | Gets the open quote character for quoting identifiers. |
| [ParameterPrefix](ISqlDialect/ParameterPrefix.md) { get; } | Gets the parameter prefix character. |
| [ScopeIdentityExpression](ISqlDialect/ScopeIdentityExpression.md) { get; } | Gets the SCOPE IDENTITY expression. |
| [ServerType](ISqlDialect/ServerType.md) { get; } | Gets the type of the server. |
| [SkipKeyword](ISqlDialect/SkipKeyword.md) { get; } | Gets the skip keyword. |
| [TakeKeyword](ISqlDialect/TakeKeyword.md) { get; } | Gets the take keyword. |
| [TimeFormat](ISqlDialect/TimeFormat.md) { get; } | Gets the time format. |
| [UseDateTime2](ISqlDialect/UseDateTime2.md) { get; } | Gets a value indicating whether the server uses the datetime2 type. |
| [UseReturningIdentity](ISqlDialect/UseReturningIdentity.md) { get; } | Gets a value indicating whether to use RETURNING identity. |
| [UseReturningIntoVar](ISqlDialect/UseReturningIntoVar.md) { get; } | Gets a value indicating whether to use RETURNING INTO variable. |
| [UseRowNum](ISqlDialect/UseRowNum.md) { get; } | Gets a value indicating whether the server supports ROWNUM. |
| [UseScopeIdentity](ISqlDialect/UseScopeIdentity.md) { get; } | Gets a value indicating whether to use SCOPE IDENTITY. |
| [UseTakeAtEnd](ISqlDialect/UseTakeAtEnd.md) { get; } | Gets a value indicating whether to use TAKE at the end. |
| [IsReservedKeyword](ISqlDialect/IsReservedKeyword.md)(…) | Returns true if the specified identifier is a SQL keyword. |
| [QuoteColumnAlias](ISqlDialect/QuoteColumnAlias.md)(…) | Quotes the column alias. This usually calls QuoteIdentifier except for Oracle. |
| [QuoteIdentifier](ISqlDialect/QuoteIdentifier.md)(…) | Quotes the identifier, escaping embedded occurrences of the dialect's closing quote character. |
| [QuoteUnicodeString](ISqlDialect/QuoteUnicodeString.md)(…) | Quotes the unicode string. |
| [UnionKeyword](ISqlDialect/UnionKeyword.md)(…) | Gets the union keyword for the specified union type. |
| [WithComparer](ISqlDialect/WithComparer.md)(…) | Returns a copy of this dialect with the specified comparer set. Dialects that support a per-connection comparer override this method; the default throws. |

## See Also

* **Source:** *[ISqlDialect.cs](https://github.com/serenity-is/Serenity/blob/f828b609b385564332aeeec6f0d6a031cde4142f/src/services/Data/Dialects/ISqlDialect.cs)*