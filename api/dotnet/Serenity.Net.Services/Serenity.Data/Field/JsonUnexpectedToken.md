# Field.JsonUnexpectedToken method
**namespace:** *[Serenity.Data](../../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Throws an exception for an unexpected JSON token when deserializing a row.

```csharp
protected static Exception JsonUnexpectedToken(JsonReader reader)
```

| parameter | description |
| --- | --- |
| reader | The reader. |

## Return Value

This method always throws.

## Exceptions

| exception | condition |
| --- | --- |
| JsonSerializationException | Unexpected token when deserializing row: " + reader.TokenType |

## See Also

* class [Field](../Field.md)