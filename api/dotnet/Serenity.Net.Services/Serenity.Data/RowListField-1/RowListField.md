# RowListField&lt;TForeign&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Field with a RowList value

```csharp
public RowListField(ICollection<Field> collection, string name, LocalText caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.NotMapped | FieldFlags.Default, 
    Func<IRow, List<TForeign>> getValue = null, Action<IRow, List<TForeign>> setValue = null)
```

| parameter | description |
| --- | --- |
| TForeign | The type of the foreign. |
| collection | The collection. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Remarks

Initializes a new instance of the [`RowListField`](../RowListField-1.md) class.

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TForeign](../Serenity.Net.Services/../RowListField-1.TForeign.md)
* class [RowListField&lt;TForeign&gt;](../RowListField-1.md)