# VariantField.GetFromReader method

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

## See Also

* interface [IRow](../IRow.md)
* class [VariantField](../VariantField.md)