# StringEnumField&lt;TStringEnum&gt; constructor

Initializes a new instance of the [`StringEnumField`](../StringEnumField-1.md) class.

```csharp
public StringEnumField(ICollection<Field> collection, string name, LocalText? caption = null, 
    int size = 0, FieldFlags flags = FieldFlags.Default, Func<IRow, string?>? getValue = null, 
    Action<IRow, string?>? setValue = null)
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
| InvalidProgramException | TStringEnum is not a StringEnum type. |

## See Also

* class [Field](../Field.md)
* class [LocalText](../../../Serenity.Net.Core/Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [StringEnumField&lt;TStringEnum&gt;](../StringEnumField-1.md)