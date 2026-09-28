# InterceptExecuteNonQueryArgs constructor

Arguments for intercepting a non-query SQL operation.

```csharp
public InterceptExecuteNonQueryArgs(string CommandText, 
    IReadOnlyDictionary<string, object?>? Parameters, ExpectedRows ExpectedRows, 
    IQueryWithParams? Query, bool GetNewId)
```

## See Also

* enum [ExpectedRows](../ExpectedRows.md)
* interface [IQueryWithParams](../IQueryWithParams.md)
* record [InterceptExecuteNonQueryArgs](../InterceptExecuteNonQueryArgs.md)