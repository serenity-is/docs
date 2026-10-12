# Field.IndexCompare method

Compares the field values for two rows for an ascending index sort using the specified comparer, falling back to [`Comparer`](./Comparer.md) when it is null.

```csharp
public abstract int IndexCompare(IRow row1, IRow row2, IComparer? comparer = null)
```

| parameter | description |
| --- | --- |
| row1 | The row1. |
| row2 | The row2. |
| comparer | The comparer to use, or null to use [`Comparer`](./Comparer.md). |

## Return Value

A value indicating the relative order of the two rows.

## Remarks

The comparer is only used when it implements IComparer for the field's value type (e.g. StringComparer for string fields, Comparer for other types). Non-generic comparers are intentionally ignored to avoid boxing value types.

## See Also

* interface [IRow](../IRow.md)
* class [Field](../Field.md)