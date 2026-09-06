# IRowOperationInterceptor.ManipulateRow method

Intercepts EntityConnectionExtensions.DeleteById method.

```csharp
public OptionalValue<long?> ManipulateRow(Type rowType, OptionalValue<object> id, IRow row, 
    ExpectedRows expectedRows, bool getNewId)
```

| parameter | description |
| --- | --- |
| rowType | Type of the row. |
| id | The identifier if Update/Delete is used. |
| row | The row being manipulated. Is null for delete. |
| expectedRows | The expected number of rows to be manipulated. Default is 1. |
| getNewId | True if InsertAndGetID is called. |

## Return Value

The generated identity value, or null if none was generated.

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* interface [IRow](../IRow.md)
* enum [ExpectedRows](../ExpectedRows.md)
* interface [IRowOperationInterceptor](../IRowOperationInterceptor.md)