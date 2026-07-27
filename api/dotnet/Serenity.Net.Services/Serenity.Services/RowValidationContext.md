# RowValidationContext class
**namespace:** *[Serenity.Services](../README.md#serenity.services-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

A validation context for rows

```csharp
public class RowValidationContext : IValidationContext
```

| parameter | description |
| --- | --- |
| connection | The connection. |
| row | The row. |
| localizer | The localizer. |

## Public Members

| name | description |
| --- | --- |
| [RowValidationContext](RowValidationContext/RowValidationContext.md)(…) | A validation context for rows |
| [Connection](RowValidationContext/Connection.md) { get; } | Gets the connection. |
| [Localizer](RowValidationContext/Localizer.md) { get; } | Localizer |
| [Value](RowValidationContext/Value.md) { get; set; } | Gets the value. |
| [GetFieldValue](RowValidationContext/GetFieldValue.md)(…) | Gets the field value. |

## Remarks

Initializes a new instance of the [`RowValidationContext`](RowValidationContext.md) class.

## See Also

* interface [IValidationContext](../Serenity/IValidationContext.md)
* **Source:** *[RowValidationContext.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/Row/RowValidationContext.cs)*