# InterceptManipulateRowArgs constructor

Arguments for intercepting an entity row manipulation operation.

```csharp
public InterceptManipulateRowArgs(Type Type, OptionalValue<object?> Id, IRow? Row, 
    ExpectedRows ExpectedRows, bool GetNewId)
```

## See Also

* struct [OptionalValue&lt;T&gt;](../../Serenity/OptionalValue-1.md)
* interface [IRow](../IRow.md)
* enum [ExpectedRows](../ExpectedRows.md)
* record [InterceptManipulateRowArgs](../InterceptManipulateRowArgs.md)