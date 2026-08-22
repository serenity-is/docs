# MigrationUtils class
**namespace:** *[Serenity.Extensions](../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Helper methods for FluentMigrator migrations, including table creation with identity keys and database type detection.

```csharp
public static class MigrationUtils
```

## Public Members

| name | description |
| --- | --- |
| static [AddOracleIdentity](MigrationUtils/AddOracleIdentity.md)(…) | Adds an Oracle sequence and trigger to generate identity values for the specified column. |
| static [AutoIncrement](MigrationUtils/AutoIncrement.md)(…) | Declares column as auto increment (e.g. Identity()) if the database is something other than Oracle, defines an Oracle sequence otherwise. It also calls NotNullable() as it is not possible for auto increment / sequence columns to be nullable. This assumes the column will NOT be set as PrimaryKey(), just as an auto incrementing value. As MySql does not support AUTO_INCREMENT without primary key or an index, this first creates the column as a regular one, then creates an index and modifies it to be an AUTO_INCREMENT. |
| static [CreateTableWithId32](MigrationUtils/CreateTableWithId32.md)(…) | Please prefer IdentityKey(this) on the fluent column builder |
| static [CreateTableWithId64](MigrationUtils/CreateTableWithId64.md)(…) | Please prefer IdentityKey(this) on the fluent column builder |
| static [EnsureDatabase](MigrationUtils/EnsureDatabase.md)(…) | Ensures the database for the specified connection key exists, creating it if necessary. |
| static [IdentityKey](MigrationUtils/IdentityKey.md)(…) | Declares column as Identity() if the database is something other than Oracle, defines an Oracle sequence otherwise. It sets the column as PrimaryKey() and also calls NotNullable() as it is not possible for identity / sequence columns to be nullable. |
| static [If&lt;TSyntax&gt;](MigrationUtils/If.md)(…) | Invokes the callback only when the predicate is true, otherwise returns the syntax unchanged. |
| static [IsDatabase](MigrationUtils/IsDatabase.md)(…) | Determines whether the migration is running against a database whose type starts with the specified name. (2 methods) |
| static [IsFirebird](MigrationUtils/IsFirebird.md)(…) | Determines whether the migration is running against a Firebird database. |
| static [IsMySql](MigrationUtils/IsMySql.md)(…) | Determines whether the migration is running against a MySql database. |
| static [IsOracle](MigrationUtils/IsOracle.md)(…) | Determines whether the migration is running against an Oracle database. |
| static [IsPostgres](MigrationUtils/IsPostgres.md)(…) | Determines whether the migration is running against a Postgres database. |
| static [IsSqlite](MigrationUtils/IsSqlite.md)(…) | Determines whether the migration is running against a Sqlite database. |
| static [IsSqlServer](MigrationUtils/IsSqlServer.md)(…) | Determines whether the migration is running against a SqlServer database. |

## See Also

* **Source:** *[MigrationUtils.cs](https://github.com/serenity-is/Serenity/blob/47a8f36cd87e4c2377c35f4a9f9c1c4ba0155f61/common-features/src/extensions/Modules/MigrationUtils/MigrationUtils.cs)*