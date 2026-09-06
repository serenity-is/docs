# IIsActiveRow.IsActiveField property

Gets the is active field. 1 means active, 0 means inactive, and if the row also has the [`IIsActiveDeletedRow`](../IIsActiveDeletedRow.md) interface, then -1 means deleted.

```csharp
public Int16Field IsActiveField { get; }
```

## Property Value

The is active field.

## See Also

* class [Int16Field](../Int16Field.md)
* interface [IIsActiveRow](../IIsActiveRow.md)