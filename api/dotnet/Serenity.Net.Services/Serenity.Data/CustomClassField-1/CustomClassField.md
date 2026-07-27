# CustomClassField&lt;TValue&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Base class for custom fields with reference type values

```csharp
public CustomClassField(ICollection<Field> collection, string name, LocalText caption, int size, 
    FieldFlags flags, Func<IRow, TValue> getValue, Action<IRow, TValue> setValue)
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

Initializes a new instance of the [`CustomClassField`](../CustomClassField-1.md) class.

## See Also

* class [GenericClassField&lt;TValue&gt;](../GenericClassField-1.md)
* class [Field](../Field.md)
* class [LocalText](../Serenity.Net.Core/../../Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TValue](../Serenity.Net.Services/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)