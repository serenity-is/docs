# CustomClassField&lt;TValue&gt;.ValueToJson method (1 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

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

# CustomClassField&lt;TValue&gt;.ValueToJson method (2 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

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

* class [TValue](../Serenity.Net.Services/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueToJson method (3 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

```csharp
public override void ValueToJson(Utf8JsonWriter writer, IRow row, JsonSerializerOptions options)
```

## See Also

* interface [IRow](../IRow.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueToJson method (4 of 4)
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Serializes the value to json

```csharp
public virtual void ValueToJson(Utf8JsonWriter writer, TValue value, JsonSerializerOptions options)
```

| parameter | description |
| --- | --- |
| writer | Writer |
| value | Value |
| options | Serializer options |

## See Also

* class [TValue](../Serenity.Net.Services/../CustomClassField-1.TValue.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)