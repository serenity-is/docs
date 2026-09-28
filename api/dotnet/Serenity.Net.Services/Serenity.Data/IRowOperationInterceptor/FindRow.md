# IRowOperationInterceptor.FindRow method

Intercepts EntityConnectionExtensions's ById/TryById/First/TryFirst/Single/TrySingle methods.

```csharp
public OptionalValue<IRow> FindRow(InterceptFindRowArgs args)
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