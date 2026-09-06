# DateOnlyField.Factory method

Static factory for field, for backward compatibility, avoid using.

```csharp
public static DateOnlyField Factory(ICollection<Field> collection, string name, LocalText caption, 
    int size, FieldFlags flags, Func<IRow, DateOnly?> getValue, Action<IRow, DateOnly?> setValue)
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

## Return Value

A new DateOnlyField instance.

## See Also

* class [Field](../Field.md)
* class [LocalText](../../../Serenity.Net.Core/Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [DateOnlyField](../DateOnlyField.md)