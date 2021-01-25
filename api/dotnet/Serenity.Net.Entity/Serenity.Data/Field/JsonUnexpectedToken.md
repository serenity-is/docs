# Field.JsonUnexpectedToken method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../../README.md)*

Jsons the unexpected token.

```csharp
protected Exception JsonUnexpectedToken(JsonReader reader)
```

| parameter | description |
| --- | --- |
| reader | The reader. |

## Exceptions

| exception | condition |
| --- | --- |
| JsonSerializationException | Unexpected token when deserializing row: " + reader.TokenType |

## See Also

* class [Field](../Field.md)