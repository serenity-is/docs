# IIsActiveRow.IsActiveField property

Gets the is active field. 1 means active, 0 means inactive, and if the row also has the [`IIsActiveDeletedRow`](../IIsActiveDeletedRow.md) interface, then -1 means deleted.

```csharp
public Int16Field IsActiveField { get; }
```

## Property Value

The is active field.

## Remarks

Note for rows that also implement [`IIsActiveDeletedRow`](../IIsActiveDeletedRow.md): deleting stores `-1` in this same column, which overwrites the previous `1` or `0`. The prior inactive state is therefore not recoverable, and undelete restores `1`.

## See Also

* class [Int16Field](../Int16Field.md)
* interface [IIsActiveRow](../IIsActiveRow.md)