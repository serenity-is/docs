# DefaultSqlErrorExtractor.ClassifyFromMessage method

Tries to classify the constraint violation type from the exception message. This is a fallback for exceptions that do not expose an error number or SQL state, and only knows the English message formats. Override to support other languages.

```csharp
protected virtual SqlErrorConstraintType? ClassifyFromMessage(string message)
```

| parameter | description |
| --- | --- |
| message | Exception message. |

## See Also

* enum [SqlErrorConstraintType](../SqlErrorConstraintType.md)
* class [DefaultSqlErrorExtractor](../DefaultSqlErrorExtractor.md)