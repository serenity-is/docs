# DefaultSqlErrorExtractor.GetErrorType method

Determines the constraint violation type from the SQL state and error number, falling back to the exception message only when neither is available.

```csharp
protected virtual SqlErrorConstraintType? GetErrorType(ServerType? serverType, int? errorNumber, 
    string? sqlState, string message)
```

| parameter | description |
| --- | --- |
| serverType | Server type, if known. |
| errorNumber | Provider error number, if known. |
| sqlState | SQL state, if known. |
| message | Exception message. |

## See Also

* enum [SqlErrorConstraintType](../SqlErrorConstraintType.md)
* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)