# IRowOperationInterceptor.ListRowsAsync method

Intercepts the async EntityConnectionExtensions List and Count methods. The default implementation forwards to [`ListRows`](./ListRows.md).

```csharp
public Task<OptionalValue<IList>> ListRowsAsync(InterceptListRowsArgs args)
```

| parameter | description |
| --- | --- |
| args | The list operation arguments. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptListRowsArgs](../InterceptListRowsArgs.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)