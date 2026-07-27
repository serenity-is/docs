# Field.ValueToJson method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Serializes this fields value to JSON

```csharp
public abstract void ValueToJson(JsonWriter writer, IRow row, JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| writer | The writer. |
| row | The row. |
| serializer | The serializer. |

## See Also

* interface [IRow](../IRow.md)
* class [Field](../Field.md)

---

# Field.ValueToJson method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Serializes this fields value to JSON

```csharp
public abstract void ValueToJson(Utf8JsonWriter writer, IRow row, JsonSerializerOptions options)
```

| parameter | description |
| --- | --- |
| row | The row. |
| writer | The writer. |
| options | The serializer options. |

## See Also

* interface [IRow](../IRow.md)
* class [Field](../Field.md)