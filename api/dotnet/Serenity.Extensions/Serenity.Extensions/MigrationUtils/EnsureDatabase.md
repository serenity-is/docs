# MigrationUtils.EnsureDatabase method

Ensures the database for the specified connection key exists, creating it if necessary.

```csharp
public static void EnsureDatabase(string databaseKey, string contentRoot, 
    ISqlConnections sqlConnections, string? collation = null, bool? partialContainment = null)
```

| parameter | description |
| --- | --- |
| databaseKey | The connection key. |
| contentRoot | The content root path, used for local databases and Sqlite files. |
| sqlConnections | The SQL connections. |
| collation | The default collation to create the database with, in the format of the database engine, e.g. Turkish_100_CI_AS for SQL Server, utf8mb4_turkish_ci for MySQL or UNICODE_CI for Firebird. For Postgres, it is a locale like tr_TR.UTF-8, or an ICU collation like tr-TR-x-icu. It only applies when the database is created here: an existing database is not changed. Defaults to the Collation of the connection, and an empty value can be passed to ignore that. It can also be one of the SqlCollationMapper keywords, which map the comparer of the connection. |
| partialContainment | True to create a SQL Server database as partially contained. This requires the "contained database authentication" setting of the server to be already enabled. Defaults to the PartialContainment of the connection. |

## Exceptions

| exception | condition |
| --- | --- |
| NotSupportedException | A collation is specified for a database type that can't be created with one, e.g. Sqlite or Oracle, an automap keyword can't map the comparer, or partial containment is requested for a database type other than SQL Server. |
| ArgumentException | The collation has invalid characters. |

## See Also

* interface [ISqlConnections](../../../Serenity.Net.Services/Serenity.Data/ISqlConnections.md)
* class [MigrationUtils](../MigrationUtils.md)