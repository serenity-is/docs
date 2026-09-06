# SqlSettings.SetLocalDialect method

Sets the local dialect for the current thread and async context. Useful for background tasks, async methods, and testing to set the dialect locally and for auto spawned threads.

```csharp
public static ISqlDialect SetLocalDialect(ISqlDialect dialect)
```

| parameter | description |
| --- | --- |
| dialect | The dialect. Can be null. |

## Return Value

The old local dialect, if any.

## See Also

* interface [ISqlDialect](../ISqlDialect.md)
* class [SqlSettings](../SqlSettings.md)