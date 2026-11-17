# IListRequestHandler.ExecutionMode property

Gets why the handler is being executed. Handlers and behaviors may check it to act differently, e.g. when the handler is only executed to build its query. The default implementation returns Normal.

```csharp
public ListExecutionMode ExecutionMode { get; }
```

## See Also

* enum [ListExecutionMode](../ListExecutionMode.md)
* interface [IListRequestHandler](../IListRequestHandler.md)