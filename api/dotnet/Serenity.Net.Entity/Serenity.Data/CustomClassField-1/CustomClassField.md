# CustomClassField&lt;TValue&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Initializes a new instance of the [`CustomClassField`](../CustomClassField-1.md) class.

```csharp
public CustomClassField(ICollection<Field> collection, string name, LocalText caption, int size, 
    FieldFlags flags, Func<IRow, TValue> getValue, Action<IRow, TValue> setValue)
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

## See Also

* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../Serenity.Net.Data/../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TValue](../Serenity.Net.Entity/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)