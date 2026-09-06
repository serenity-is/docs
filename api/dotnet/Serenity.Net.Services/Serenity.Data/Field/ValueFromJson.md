# Field.ValueFromJson method (1 of 2)

Deserializes this field's value from JSON.

```csharp
public abstract void ValueFromJson(JsonReader reader, IRow row, JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| row | The row. |
| serializer | The serializer. |

## See Also

* interface [IRow](../IRow.md)
* class [Field](../Field.md)

---

# Field.ValueFromJson method (2 of 2)

Deserializes this field's value from JSON.

```csharp
public abstract void ValueFromJson(ref Utf8JsonReader reader, IRow row, 
    JsonSerializerOptions options)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| row | The row. |
| options | The serializer options. |

## See Also

* interface [IRow](../IRow.md)
* class [Field](../Field.md)