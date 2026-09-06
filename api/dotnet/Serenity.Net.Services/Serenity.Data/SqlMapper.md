# SqlMapper class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Provides IDbConnection extension methods that wrap the corresponding Dapper SqlMapper methods, translating Serenity SQL (dialect specific brackets and parameter prefixes) via [`Translate`](./SqlConversions/Translate.md) and ensuring the connection is open before execution. It mirrors the string based `Execute` and `Query` extension methods of Dapper's `SqlMapper`, not every Dapper overload (CommandDefinition based methods, ExecuteScalar, ExecuteReader, QueryFirst, QueryMultiple, etc.), as well as their async variants. The [`ISqlQuery`](./ISqlQuery.md) overloads are Serenity specific and have no Dapper equivalent. Note that unlike [`SqlHelper`](./SqlHelper.md) methods, these extension methods do not go through [`ISqlOperationInterceptor`](./ISqlOperationInterceptor.md).

```csharp
public static class SqlMapper
```

## Public Members

| name | description |
| --- | --- |
| static [Execute](SqlMapper/Execute.md)(…) | Executes a parameterized SQL statement. |
| static [ExecuteAsync](SqlMapper/ExecuteAsync.md)(…) | Executes a parameterized SQL statement asynchronously. |
| static [Query](SqlMapper/Query.md)(…) | Returns a list of dynamic objects; the reader is closed after the call. (2 methods) |
| static [Query&lt;T&gt;](SqlMapper/Query.md)(…) | Returns a list of objects; the reader is closed after the call. (2 methods) |
| static [QueryAsync](SqlMapper/QueryAsync.md)(…) | Returns a list of dynamic objects asynchronously; the reader is closed after the call. (2 methods) |
| static [QueryAsync&lt;T&gt;](SqlMapper/QueryAsync.md)(…) | Returns a list of objects asynchronously; the reader is closed after the call. (2 methods) |

## See Also

* **Source:** *[DapperCore.cs](https://github.com/serenity-is/Serenity/blob/5445cb1a4cff73ddcb1836e22ed93205899c0812/src/services/Data/SqlHelpers/DapperCore.cs)*