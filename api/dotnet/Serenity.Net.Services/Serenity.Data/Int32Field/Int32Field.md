# Int32Field constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Field with Int32 value

```csharp
public Int32Field(ICollection<Field> collection, string name, LocalText caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.Default, Func<IRow, int?> getValue = null, 
    Action<IRow, int?> setValue = null)
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

Initializes a new instance of the [`Int32Field`](../Int32Field.md) class.

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [Int32Field](../Int32Field.md)