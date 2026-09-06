# JsonField&lt;TValue&gt; constructor

Field with a JSON value.

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
* class [LocalText](../../../Serenity.Net.Core/Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [JsonField&lt;TValue&gt;](../JsonField-1.md)