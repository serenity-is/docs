# ISqlErrorExtractor.Extract method

Extracts constraint violation information from the given exception, or returns `null` if it is not a recognized constraint violation.

```csharp
public SqlErrorInfo? Extract(Exception exception, SqlErrorExtractOptions? options = null)
```

| parameter | description |
| --- | --- |
| exception | Exception that occurred during a database operation. |
| options | Optional extraction options, e.g. the server type taken from the current connection's dialect, which takes precedence over type name based inference. |

## See Also

* class [SqlErrorInfo](../SqlErrorInfo.md)
* class [SqlErrorExtractOptions](../SqlErrorExtractOptions.md)
* interface [ISqlErrorExtractor](../ISqlErrorExtractor.md)