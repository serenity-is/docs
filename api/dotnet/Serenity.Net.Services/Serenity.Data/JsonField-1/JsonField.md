# JsonField&lt;TValue&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Field with JSON value

```csharp
public JsonField(ICollection<Field> collection, string name, LocalText caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.Default, Func<IRow, TValue> getValue = null, 
    Action<IRow, TValue> setValue = null)
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |
| collection | The collection. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Remarks

Initializes a new instance of the [`JsonField`](../JsonField-1.md) class.

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TValue](../Serenity.Net.Services/../JsonField-1.TValue.md)
* class [JsonField&lt;TValue&gt;](../JsonField-1.md)