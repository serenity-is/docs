# EnumField&lt;TEnum&gt; constructor

Initializes a new instance of the [`EnumField`](../EnumField-1.md) class.

```csharp
public EnumField(ICollection<Field> collection, string name, LocalText caption = null, 
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

## Exceptions

| exception | condition |
| --- | --- |
| InvalidProgramException | TEnum is not an enum type or is not based on Int32. |

## See Also

* class [Field](../Field.md)
* class [LocalText](../../../Serenity.Net.Core/Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [EnumField&lt;TEnum&gt;](../EnumField-1.md)