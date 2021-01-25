# GenericField&lt;TValue&gt; constructor
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Initializes a new instance of the [`GenericField`](../GenericField-1.md) class.

```csharp
public GenericField(ICollection<Field> collection, FieldType type, string name, string caption, 
    int size, FieldFlags flags, Func<IRow, TValue> getValue, Action<IRow, TValue> setValue)
```

| parameter | description |
| --- | --- |
| collection | The collection. |
| type | The type. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## See Also

* class [Field](../Field.md)
* enum [FieldType](../FieldType.md)
* enum [FieldFlags](../Serenity.Net.Data/../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [TValue](../Serenity.Net.Entity/../GenericField-1.TValue.md)
* class [GenericField&lt;TValue&gt;](../GenericField-1.md)