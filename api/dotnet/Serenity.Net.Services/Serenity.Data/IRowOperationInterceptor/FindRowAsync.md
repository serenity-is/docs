# IRowOperationInterceptor.FindRowAsync method

Intercepts the async EntityConnectionExtensions ById/TryById/First/TryFirst/Single/TrySingle methods. The default implementation forwards to [`FindRow`](./FindRow.md).

```csharp
public Task<OptionalValue<IRow>> FindRowAsync(InterceptFindRowArgs args)
```

| parameter | description |
| --- | --- |
| args | The find operation arguments. |

## Return Value

Entity with the given ID, or null if not found.

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* interface [IRow](../IRow.md)
* record [InterceptFindRowArgs](../InterceptFindRowArgs.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)