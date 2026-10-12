# GenericClassField&lt;TValue&gt;.IndexCompare method

Compares the field values for two rows for an ascending index sort using the specified comparer, falling back to [`Comparer`](../Field/Comparer.md) when it is null.

```csharp
public override int IndexCompare(IRow row1, IRow row2, IComparer? comparer = null)
```

| parameter | description |
| --- | --- |
| row1 | The row1. |
| row2 | The row2. |
| comparer | The comparer, or null to use the field comparer. |

## Return Value

A value indicating the relative order of the two rows.

## See Also

* interface [IRow](../IRow.md)
* class [GenericClassField&lt;TValue&gt;](../GenericClassField-1.md)