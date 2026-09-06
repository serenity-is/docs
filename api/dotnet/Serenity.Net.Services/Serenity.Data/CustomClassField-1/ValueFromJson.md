# CustomClassField&lt;TValue&gt;.ValueFromJson method (1 of 4)

Deserializes this field's value from JSON.

```csharp
protected virtual TValue ValueFromJson(JsonReader reader, JsonSerializer serializer)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| serializer | The serializer. |

## Return Value

The deserialized value.

## See Also

* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueFromJson method (2 of 4)

Deserializes this field's value from JSON.

```csharp
protected virtual TValue ValueFromJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
```

| parameter | description |
| --- | --- |
| reader | The reader. |
| options | The serializer options. |

## Return Value

The deserialized value.

## See Also

* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueFromJson method (3 of 4)

Deserializes this field's value from JSON.

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
| ArgumentNullException | reader is null. |

## See Also

* interface [IRow](../IRow.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)

---

# CustomClassField&lt;TValue&gt;.ValueFromJson method (4 of 4)

```csharp
public override void ValueFromJson(ref Utf8JsonReader reader, IRow row, 
    JsonSerializerOptions options)
```

## See Also

* interface [IRow](../IRow.md)
* class [CustomClassField&lt;TValue&gt;](../CustomClassField-1.md)