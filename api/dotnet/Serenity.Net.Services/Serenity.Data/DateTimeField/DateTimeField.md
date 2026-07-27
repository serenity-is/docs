# DateTimeField constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Field with a DateTime value

```csharp
public DateTimeField(ICollection<Field> collection, string name, LocalText caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.Default, Func<IRow, DateTime?> getValue = null, 
    Action<IRow, DateTime?> setValue = null)
```

| parameter | description |
| --- | --- |
| collection | The collection. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Remarks

Initializes a new instance of the [`DateTimeField`](../DateTimeField.md) class.

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [DateTimeField](../DateTimeField.md)