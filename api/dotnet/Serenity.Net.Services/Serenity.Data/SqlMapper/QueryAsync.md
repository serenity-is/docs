# SqlMapper.QueryAsync method (1 of 4)

Returns a list of dynamic objects asynchronously; the reader is closed after the call. Serenity specific overload for [`ISqlQuery`](../ISqlQuery.md), not present in Dapper.

```csharp
public static Task<IEnumerable<object>> QueryAsync(this IDbConnection cnn, ISqlQuery sql, 
    IDbTransaction transaction = null, int? commandTimeout = null, 
    CommandType? commandType = default, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| cnn | The connection. |
| sql | The SQL query. |
| transaction | The transaction. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains a list of dynamic objects.

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.QueryAsync method (2 of 4)

Returns a list of dynamic objects asynchronously; the reader is closed after the call.

```csharp
public static Task<IEnumerable<object>> QueryAsync(this IDbConnection cnn, string sql, 
    object param = null, IDbTransaction transaction = null, int? commandTimeout = null, 
    CommandType? commandType = default, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| cnn | The connection. |
| sql | The SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains a list of dynamic objects.

## See Also

* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.QueryAsync&lt;T&gt; method (3 of 4)

Returns a list of values asynchronously; the reader is closed after the call. Serenity specific overload for [`ISqlQuery`](../ISqlQuery.md), not present in Dapper.

```csharp
public static Task<IEnumerable<T>> QueryAsync<T>(this IDbConnection cnn, ISqlQuery sql, 
    IDbTransaction transaction = null, int? commandTimeout = null, 
    CommandType? commandType = default, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| T | The type of the value. |
| cnn | The connection. |
| sql | The SQL query. |
| transaction | The transaction. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains a list of values.

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.QueryAsync&lt;T&gt; method (4 of 4)

Returns a list of objects asynchronously; the reader is closed after the call.

```csharp
public static Task<IEnumerable<T>> QueryAsync<T>(this IDbConnection cnn, string sql, 
    object param = null, IDbTransaction transaction = null, int? commandTimeout = null, 
    CommandType? commandType = default, CancellationToken cancellationToken = default)
```

| parameter | description |
| --- | --- |
| T | The type of the objects to return. |
| cnn | The connection. |
| sql | The SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |
| cancellationToken | The cancellation token. |

## Return Value

A task that represents the asynchronous operation. The task result contains a list of objects.

## See Also

* class [SqlMapper](../SqlMapper.md)