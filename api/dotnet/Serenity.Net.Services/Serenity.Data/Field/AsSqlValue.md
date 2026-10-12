# Field.AsSqlValue method

Gets the value of this row as an SQL value.

```csharp
public virtual object? AsSqlValue(IRow row)
```

| parameter | description |
| --- | --- |
| row | The row. |

## Return Value

The value of the field in the row as an SQL value.

## Remarks

This simply calls AsObject, it is only provided for subclasses like ByteArrayField to convert it to a suitable param value, for example null =&gt; System.Data.SqlTypes.SqlBinary.Null

## See Also

* interface [IRow](../IRow.md)
* class [Field](../Field.md)