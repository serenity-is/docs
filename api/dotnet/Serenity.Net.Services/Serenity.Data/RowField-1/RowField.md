# RowField&lt;TForeign&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Field with a Row value

```csharp
public RowField(ICollection<Field> collection, string name, LocalText caption = null, int size = 0, 
    FieldFlags flags = FieldFlags.NotMapped | FieldFlags.Default, 
    Func<IRow, TForeign> getValue = null, Action<IRow, TForeign> setValue = null)
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

Initializes a new instance of the [`RowField`](../RowField-1.md) class.

## See Also

* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)
* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TForeign](../Serenity.Net.Services/../RowField-1.TForeign.md)
* class [RowField&lt;TForeign&gt;](../RowField-1.md)