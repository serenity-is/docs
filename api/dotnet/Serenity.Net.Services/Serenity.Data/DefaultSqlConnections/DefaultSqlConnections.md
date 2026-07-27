# DefaultSqlConnections constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Default connection factory

```csharp
public DefaultSqlConnections(IConnectionStrings connectionStrings, 
    IConnectionProfiler profiler = null, ILoggerFactory loggerFactory = null)
```

| parameter | description |
| --- | --- |
| connectionStrings | Named connection strings |
| profiler | Profiler if any |
| loggerFactory | Optional logger factory (to be used by static SqlHelper methods) |

## Remarks

Creates a new instance

## See Also

* interface [IConnectionStrings](../IConnectionStrings.md)
* interface [IConnectionProfiler](../IConnectionProfiler.md)
* class [DefaultSqlConnections](../DefaultSqlConnections.md)