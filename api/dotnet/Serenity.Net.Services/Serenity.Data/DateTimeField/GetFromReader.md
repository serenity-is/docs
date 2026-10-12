# DateTimeField.GetFromReader method

Gets field value from a data reader.

```csharp
public override void GetFromReader(IDataReader reader, int index, IRow row)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| index | The index. |
| row | The row. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | reader is null. |

## Remarks

The value returned by the data reader is assumed to already be stored in the field's [`DateTimeKind`](./DateTimeKind.md); the kind is only labeled via DateTimeKind), not converted.

## See Also

* interface [IRow](../IRow.md)
* class [DateTimeField](../DateTimeField.md)