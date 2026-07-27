# CustomClassField&lt;TValue&gt;.ValueFromJson method (1 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Deserializes this fields value from JSON

```csharp
protected virtual TValue ValueFromJson(JsonReader reader, JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| serializer | The serializer. |

## See Also

* class [TValue](../Serenity.Net.Services/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueFromJson method (2 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Deserializes this fields value from JSON

```csharp
protected virtual TValue ValueFromJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| options | Serializer options |

## See Also

* class [TValue](../Serenity.Net.Services/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueFromJson method (3 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

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

---

# CustomClassField&lt;TValue&gt;.ValueFromJson method (4 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public override void ValueFromJson(ref Utf8JsonReader reader, IRow row, 
    JsonSerializerOptions options)
```

## See Also

* interface [IRow](../IRow.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)