# JsonField&lt;TValue&gt;.GetFromReader method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

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
| ArgumentNullException | reader |

## See Also

* interface [IRow](../IRow.md)
* class [JsonField&lt;TValue&gt;](../JsonField-1.md)