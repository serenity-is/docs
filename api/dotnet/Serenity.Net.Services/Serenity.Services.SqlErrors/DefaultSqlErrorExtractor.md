# DefaultSqlErrorExtractor class
**namespace:** *[Serenity.Services.SqlErrors](../README.md#serenity.services.sqlerrors-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Default [`ISqlErrorExtractor`](./ISqlErrorExtractor.md) that recognizes primary key, unique, foreign key and not null constraint violations for common database providers without referencing any provider specific package.

```csharp
public class DefaultSqlErrorExtractor : ISqlErrorExtractor
```

## Public Members

| name | description |
| --- | --- |
| [DefaultSqlErrorExtractor](DefaultSqlErrorExtractor/DefaultSqlErrorExtractor.md)() | The default constructor. |
| [Extract](DefaultSqlErrorExtractor/Extract.md)(…) |  |

## Protected Members

| name | description |
| --- | --- |
| virtual [ClassifyFromMessage](DefaultSqlErrorExtractor/ClassifyFromMessage.md)(…) | Tries to classify the constraint violation type from the exception message. This is a fallback for exceptions that do not expose an error number or SQL state, and only knows the English message formats. Override to support other languages. |
| virtual [Extract](DefaultSqlErrorExtractor/Extract.md)(…) | Extracts constraint violation information from a database exception. |
| virtual [GetErrorNumber](DefaultSqlErrorExtractor/GetErrorNumber.md)(…) | Tries to get the provider error number from the exception using reflection. |
| virtual [GetErrorType](DefaultSqlErrorExtractor/GetErrorType.md)(…) | Determines the constraint violation type from the SQL state and error number, falling back to the exception message only when neither is available. |
| virtual [GetServerType](DefaultSqlErrorExtractor/GetServerType.md)(…) | Tries to determine the [`ServerType`](../Serenity.Data/ServerType.md) from the exception type without referencing provider specific assemblies. |
| virtual [ParseErrorInfo](DefaultSqlErrorExtractor/ParseErrorInfo.md)(…) | Tries to parse table, column, constraint and key value names from the exception message. Only stable/known culture formats are matched; other languages may leave the names empty, in which case a generic message should be used. |
| static readonly [SqlServerMessageRegexes](DefaultSqlErrorExtractor/SqlServerMessageRegexes.md) | Regexes generated from SQL Server sys.messages for the handled constraint violation message ids (515, 547, 2601, 2627), one per language. Named groups: `table`, `column`, `constraint`, `value`. |
| static [DoubleQuotedConstraintRegex](DefaultSqlErrorExtractor/DoubleQuotedConstraintRegex.md)() |  |
| static [FirebirdConstraintRegex](DefaultSqlErrorExtractor/FirebirdConstraintRegex.md)() |  |
| static [FirebirdTableRegex](DefaultSqlErrorExtractor/FirebirdTableRegex.md)() |  |
| static [MatchAny](DefaultSqlErrorExtractor/MatchAny.md)(…) | Returns the first successful match from the passed regex array, or `null`. |
| static [MySqlColumnsRegex](DefaultSqlErrorExtractor/MySqlColumnsRegex.md)() |  |
| static [MySqlKeyRegex](DefaultSqlErrorExtractor/MySqlKeyRegex.md)() |  |
| static [MySqlReferencedTableRegex](DefaultSqlErrorExtractor/MySqlReferencedTableRegex.md)() |  |
| static [OracleConstraintRegex](DefaultSqlErrorExtractor/OracleConstraintRegex.md)() |  |
| static [ParseServerType](DefaultSqlErrorExtractor/ParseServerType.md)(…) | Parses a server type name, e.g. from [`ServerType`](../Serenity.Data/ISqlDialect/ServerType.md), returning `null` if it is not a known [`ServerType`](../Serenity.Data/ServerType.md). |
| static [PostgresColumnsRegex](DefaultSqlErrorExtractor/PostgresColumnsRegex.md)() |  |
| static [PostgresForeignKeyOnTableRegex](DefaultSqlErrorExtractor/PostgresForeignKeyOnTableRegex.md)() |  |
| static [PostgresReferencedTableRegex](DefaultSqlErrorExtractor/PostgresReferencedTableRegex.md)() |  |
| static [PostgresTableRegex](DefaultSqlErrorExtractor/PostgresTableRegex.md)() |  |
| static [SingleQuotedConstraintRegex](DefaultSqlErrorExtractor/SingleQuotedConstraintRegex.md)() |  |
| static [SqliteColumnsRegex](DefaultSqlErrorExtractor/SqliteColumnsRegex.md)() |  |
| static [SqlServerForeignKeyRegex](DefaultSqlErrorExtractor/SqlServerForeignKeyRegex.md)() |  |
| static [SqlServerKeyValueRegex](DefaultSqlErrorExtractor/SqlServerKeyValueRegex.md)() |  |
| static [SqlServerObjectRegex](DefaultSqlErrorExtractor/SqlServerObjectRegex.md)() |  |

## Remarks

Error types are determined primarily from language independent error numbers and SQL state codes. Table, column and constraint names are only extracted from the exception message where the message format is stable (e.g. SQLite) or matches one of the culture specific patterns. Override [`ParseErrorInfo`](./DefaultSqlErrorExtractor/ParseErrorInfo.md) to support additional languages. When names cannot be determined, [`SqlErrorInfo`](./SqlErrorInfo.md) falls back to a generic message.

## See Also

* interface [ISqlErrorExtractor](./ISqlErrorExtractor.md)
* **Source:** *[DefaultSqlErrorExtractor.cs](https://github.com/serenity-is/Serenity/blob/def898fccb288f7bf46d2059f75ecc84fbf57379/src/services/RequestHandlers/IntegratedFeatures/SqlErrors/DefaultSqlErrorExtractor.cs)*