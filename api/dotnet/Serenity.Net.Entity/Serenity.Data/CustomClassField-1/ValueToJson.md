# CustomClassField&lt;TValue&gt;.ValueToJson method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Serializes this fields value to JSON

```csharp
public override void ValueToJson(JsonWriter writer, IRow row, JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| writer | The writer. |
| row | The row. |
| serializer | The serializer. |

## See Also

* interface [IRow](../IRow.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueToJson method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Serializes this fields value to JSON

```csharp
public virtual void ValueToJson(JsonWriter writer, TValue value, JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| writer | The writer. |
| value | The value. |
| serializer | The serializer. |

## See Also

* class [TValue](../Serenity.Net.Entity/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)