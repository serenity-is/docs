# DefaultSqlErrorExtractor.ParseErrorInfo method

Tries to parse table, column, constraint and key value names from the exception message. Only stable/known culture formats are matched; other languages may leave the names empty, in which case a generic message should be used.

```csharp
protected virtual void ParseErrorInfo(SqlErrorInfo info, string message, ServerType? serverType)
```

| parameter | description |
| --- | --- |
| info | Error info to fill. |
| message | Exception message. |
| serverType | Server type, if known. |

## See Also

* class [SqlErrorInfo](../SqlErrorInfo.md)
* enum [ServerType](../../Serenity.Data/ServerType.md)
* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)