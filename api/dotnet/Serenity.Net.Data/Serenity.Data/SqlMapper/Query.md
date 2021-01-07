# SqlMapper.Query method (1 of 7)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Return a list of dynamic objects, reader is closed after the call

```csharp
public static IEnumerable<object> Query(this IDbConnection cnn, string sql, object param, 
    CommandType? commandType)
```

| parameter | description |
| --- | --- |
| cnn | Connection. |
| sql | SQL query. |
| param | The parameters. |
| commandType | Type of the command. |

## Return Value

List of dynamic objects

## See Also

* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query method (2 of 7)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Return a list of dynamic objects, reader is closed after the call

```csharp
public static IEnumerable<object> Query(this IDbConnection cnn, string sql, object param, 
    IDbTransaction transaction)
```

| parameter | description |
| --- | --- |
| cnn | Connection. |
| sql | SQL query. |
| param | The parameters. |
| transaction | The transaction. |

## Return Value

List of values

## See Also

* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query method (3 of 7)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Return a list of dynamic objects, reader is closed after the call

```csharp
public static IEnumerable<object> Query(this IDbConnection cnn, string sql, object param, 
    IDbTransaction transaction, CommandType? commandType)
```

| parameter | description |
| --- | --- |
| cnn | Connection. |
| sql | SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| commandType | Type of the command. |

## Return Value

List of dynamic objects

## See Also

* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query method (4 of 7)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Return a list of dynamic objects, reader is closed after the call

```csharp
public static IEnumerable<object> Query(this IDbConnection cnn, ISqlQuery sql, 
    IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, 
    CommandType? commandType = default(CommandType?))
```

| parameter | description |
| --- | --- |
| cnn | Connection. |
| sql | SQL query. |
| transaction | The transaction. |
| buffered | if set to `true` results are buffered. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

List of dynamic objects

## See Also

* interface [ISqlQuery](../ISqlQuery.md)
* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query method (5 of 7)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Return a list of dynamic objects, reader is closed after the call

```csharp
public static IEnumerable<object> Query(this IDbConnection cnn, string sql, object param = null, 
    IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, 
    CommandType? commandType = default(CommandType?))
```

| parameter | description |
| --- | --- |
| cnn | Connection. |
| sql | SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| buffered | if set to `true` results are buffered. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

List of dynamic objects

## See Also

* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query&lt;TValue&gt; method (6 of 7)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Return a list of values, reader is closed after the call

```csharp
public static IEnumerable<TValue> Query<TValue>(this IDbConnection cnn, ISqlQuery sql, 
    IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, 
    CommandType? commandType = default(CommandType?))
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |
| cnn | Connection. |
| sql | SQL query. |
| transaction | The transaction. |
| buffered | if set to `true` results are buffered. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

List of values

## See Also

* class [TValue](../Serenity.Net.Data/../SqlMapper.TValue.md)
* interface [ISqlQuery](../ISqlQuery.md)
* class [SqlMapper](../SqlMapper.md)

---

# SqlMapper.Query&lt;T&gt; method (7 of 7)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Data](../../README.md)*

Return a list of objects, reader is closed after the call

```csharp
public static IEnumerable<T> Query<T>(this IDbConnection cnn, string sql, object param = null, 
    IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, 
    CommandType? commandType = default(CommandType?))
```

| parameter | description |
| --- | --- |
| T |  |
| cnn | Connection. |
| sql | SQL query. |
| param | The parameters. |
| transaction | The transaction. |
| buffered | if set to `true` results are buffered. |
| commandTimeout | The command timeout. |
| commandType | Type of the command. |

## Return Value

List of objects

## See Also

* class [T](../Serenity.Net.Data/../SqlMapper.T.md)
* class [SqlMapper](../SqlMapper.md)