# IRowOperationInterceptor.ListRows method

Intercepts EntityConnectionExtensions.List and Count methods.

```csharp
public OptionalValue<IList> ListRows(InterceptListRowsArgs args)
```

| parameter | description |
| --- | --- |
| args | The list operation arguments. |

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* record [InterceptListRowsArgs](../InterceptListRowsArgs.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)