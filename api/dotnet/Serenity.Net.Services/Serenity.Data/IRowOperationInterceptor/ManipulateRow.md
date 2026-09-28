# IRowOperationInterceptor.ManipulateRow method

Intercepts EntityConnectionExtensions.DeleteById method.

```csharp
public OptionalValue<long?> ManipulateRow(InterceptManipulateRowArgs args)
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