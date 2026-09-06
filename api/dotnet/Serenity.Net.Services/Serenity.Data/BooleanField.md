# BooleanField class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Field with a boolean value.

```csharp
public sealed class BooleanField : GenericValueField<bool>
```

| parameter | description |
| --- | --- |
| collection | The field collection. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value callback. |
| setValue | The set value callback. |

## Public Members

| name | description |
| --- | --- |
| [BooleanField](BooleanField/BooleanField.md)(…) | Field with a boolean value. |
| static [Factory](BooleanField/Factory.md)(…) | Static factory for field, for backward compatibility, avoid using. |
| override [GetFromReader](BooleanField/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [ValueFromJson](BooleanField/ValueFromJson.md)(…) | Gets the field value from JSON. (2 methods) |
| override [ValueToJson](BooleanField/ValueToJson.md)(…) | Converts the field value to JSON. (2 methods) |

## Remarks

Initializes a new instance of the [`BooleanField`](./BooleanField.md) class.

## See Also

* class [GenericValueField&lt;TValue&gt;](./GenericValueField-1.md)
* **Source:** *[BooleanField.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/services/Entity/FieldTypes/BooleanField.cs)*