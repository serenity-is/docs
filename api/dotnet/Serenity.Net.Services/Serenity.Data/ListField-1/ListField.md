# ListField&lt;TItem&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Field with a list value

```csharp
public ListField(ICollection<Field> collection, string name, LocalText caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.NotMapped | FieldFlags.Default, 
    Func<IRow, List<TItem>> getValue = null, Action<IRow, List<TItem>> setValue = null)
```

| parameter | description |
| --- | --- |
| TItem | The type of the item. |
| collection | The collection. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Remarks

Initializes a new instance of the [`ListField`](../ListField-1.md) class.

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TItem](../Serenity.Net.Services/../ListField-1.TItem.md)
* class [ListField&lt;TItem&gt;](../ListField-1.md)