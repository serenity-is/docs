# Int64Field constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Field with Int64 value

```csharp
public Int64Field(ICollection<Field> collection, string name, LocalText caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.Default, Func<IRow, long?> getValue = null, 
    Action<IRow, long?> setValue = null)
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

Initializes a new instance of the [`Int64Field`](../Int64Field.md) class.

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [Int64Field](../Int64Field.md)