# BooleanField.ValueFromJson method (1 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Gets field value from JSON.

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
| ArgumentNullException | reader is null |

## See Also

* interface [IRow](../IRow.md)
* class [BooleanField](../BooleanField.md)

---

# BooleanField.ValueFromJson method (2 of 2)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public override void ValueFromJson(ref Utf8JsonReader reader, IRow row, 
    JsonSerializerOptions options)
```

## See Also

* interface [IRow](../IRow.md)
* class [BooleanField](../BooleanField.md)