# GenericField&lt;TValue&gt; constructor

Base generic class for fields with a value.

```csharp
protected GenericField(ICollection<Field> collection, FieldType type, string name, string caption, 
    int size, FieldFlags flags, Func<IRow, TValue> getValue, Action<IRow, TValue> setValue)
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |
| collection | The collection. |
| type | The type. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Remarks

Initializes a new instance of the [`GenericField`](../GenericField-1.md) class.

## See Also

* class [Field](../Field.md)
* enum [FieldType](../FieldType.md)
* enum [FieldFlags](../FieldFlags.md)
* interface [IRow](../IRow.md)
* class [GenericField&lt;TValue&gt;](../GenericField-1.md)