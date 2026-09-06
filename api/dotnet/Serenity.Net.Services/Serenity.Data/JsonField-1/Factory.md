# JsonField&lt;TValue&gt;.Factory method

Static factory for field, for backward compatibility, avoid using.

```csharp
public static JsonField Factory(ICollection<Field> collection, string name, LocalText caption, 
    int size, FieldFlags flags, Func<IRow, TValue> getValue, Action<IRow, TValue> setValue)
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

A new JsonField instance.

## See Also

* class [Field](../Field.md)
* class [LocalText](../../../Serenity.Net.Core/Serenity/LocalText.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [JsonField&lt;TValue&gt;](../JsonField-1.md)