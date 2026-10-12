# SqlMapper.Query method (1 of 4)

Returns a list of dynamic objects; the reader is closed after the call. Serenity specific overload for [`ISqlQuery`](../ISqlQuery.md), not present in Dapper.

```csharp
public static IEnumerable<object> Query(this IDbConnection cnn, ISqlQuery sql, 
    IDbTransaction? transaction = null, bool buffered = true, int? commandTimeout = null, 
    CommandType? commandType = default)
```

| parameter | description |
| --- | --- |
| cnn | The connection. |
| sql | The SQL query. |
| transaction | The transaction. |
| buffered | If set to `true` (the default), results are buffered. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

List of dynamic objects.

## Remarks

With `buffered: false` execution is deferred: the connection must stay open until enumeration completes, otherwise enumeration throws.

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query method (2 of 4)

Returns a list of dynamic objects; the reader is closed after the call.

```csharp
public static IEnumerable<object> Query(this IDbConnection cnn, string sql, object? param = null, 
    IDbTransaction? transaction = null, bool buffered = true, int? commandTimeout = null, 
    CommandType? commandType = default)
```

| parameter | description |
| --- | --- |
| cnn | The connection. |
| sql | The SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| buffered | If set to `true` (the default), results are buffered. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

List of dynamic objects.

## Remarks

With `buffered: false` execution is deferred: the connection must stay open until enumeration completes, otherwise enumeration throws.

## See Also

* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query&lt;T&gt; method (3 of 4)

Returns a list of values; the reader is closed after the call. Serenity specific overload for [`ISqlQuery`](../ISqlQuery.md), not present in Dapper.

```csharp
public static IEnumerable<T> Query<T>(this IDbConnection cnn, ISqlQuery sql, 
    IDbTransaction? transaction = null, bool buffered = true, int? commandTimeout = null, 
    CommandType? commandType = default)
```

| parameter | description |
| --- | --- |
| T | The type of the value. |
| cnn | The connection. |
| sql | The SQL query. |
| transaction | The transaction. |
| buffered | If set to `true` (the default), results are buffered. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

List of values.

## Remarks

With `buffered: false` execution is deferred: the connection must stay open until enumeration completes, otherwise enumeration throws.

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query&lt;T&gt; method (4 of 4)

Returns a list of objects; the reader is closed after the call.

```csharp
public static IEnumerable<T> Query<T>(this IDbConnection cnn, string sql, object? param = null, 
    IDbTransaction? transaction = null, bool buffered = true, int? commandTimeout = null, 
    CommandType? commandType = default)
```

| parameter | description |
| --- | --- |
| T | The type of the objects to return. |
| cnn | The connection. |
| sql | The SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| buffered | If set to `true` (the default), results are buffered. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

List of objects.

## Remarks

With `buffered: false` execution is deferred: the connection must stay open until enumeration completes, otherwise enumeration throws.

## See Also

* class [SqlMapper](../SqlMapper.md)