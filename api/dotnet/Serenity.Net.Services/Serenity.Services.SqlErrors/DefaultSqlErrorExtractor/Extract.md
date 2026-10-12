# DefaultSqlErrorExtractor.Extract method (1 of 2)

Extracts constraint violation information from a database exception.

```csharp
protected virtual SqlErrorInfo? Extract(DbException exception, SqlErrorExtractOptions? options)
```

| parameter | description |
| --- | --- |
| exception | The database exception. |
| options | Optional extraction options, e.g. the server type. |

## See Also

* class [SqlErrorInfo](../SqlErrorInfo.md)
* class [SqlErrorExtractOptions](../SqlErrorExtractOptions.md)
* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)

---

# DefaultSqlErrorExtractor.Extract method (2 of 2)

```csharp
public SqlErrorInfo? Extract(Exception exception, SqlErrorExtractOptions? options = null)
```

## See Also

* class [SqlErrorInfo](../SqlErrorInfo.md)
* class [SqlErrorExtractOptions](../SqlErrorExtractOptions.md)
* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)