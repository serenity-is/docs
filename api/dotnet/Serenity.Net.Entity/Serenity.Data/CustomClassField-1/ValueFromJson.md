# CustomClassField&lt;TValue&gt;.ValueFromJson method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Deserializes this fields value from JSON

```csharp
protected virtual TValue ValueFromJson(JsonReader reader, JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| serializer | The serializer. |

## See Also

* class [TValue](../Serenity.Net.Entity/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueFromJson method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Deserializes this fields value from JSON

```csharp
public override void ValueFromJson(JsonReader reader, IRow row, JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| row | The row. |
| serializer | The serializer. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | reader |

## See Also

* interface [IRow](../IRow.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)