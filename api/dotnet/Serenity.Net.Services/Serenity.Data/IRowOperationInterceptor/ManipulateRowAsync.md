# IRowOperationInterceptor.ManipulateRowAsync method

Intercepts the async EntityConnectionExtensions DeleteById/Insert/Update methods. The default implementation forwards to [`ManipulateRow`](./ManipulateRow.md).

```csharp
public Task<OptionalValue<long?>> ManipulateRowAsync(InterceptManipulateRowArgs args)
```

| parameter | description |
| --- | --- |
| args | The row manipulation arguments. |

## Return Value

The generated identity value, or null if none was generated.

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptManipulateRowArgs](../InterceptManipulateRowArgs.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)