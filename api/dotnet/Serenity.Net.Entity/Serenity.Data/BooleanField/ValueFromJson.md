# BooleanField.ValueFromJson method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

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