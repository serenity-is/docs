# CustomClassField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base class for custom fields with reference type values

```csharp
public class CustomClassField<TValue> : GenericClassField<TValue>
    where TValue : class
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |
| collection | The collection. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Public Members

| name | description |
| --- | --- |
| [CustomClassField](CustomClassField-1/CustomClassField.md)(…) | Base class for custom fields with reference type values |
| override [Copy](CustomClassField-1/Copy.md)(…) | Copies the specified source. |
| override [GetFromReader](CustomClassField-1/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](CustomClassField-1/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](CustomClassField-1/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |
| override [ValueToJson](CustomClassField-1/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |
| virtual [ValueToJson](CustomClassField-1/ValueToJson.md)(…) | Serializes this fields value to JSON (2 methods) |

## Protected Members

| name | description |
| --- | --- |
| virtual [Clone](CustomClassField-1/Clone.md)(…) | Clones the specified value. |
| virtual [CompareValues](CustomClassField-1/CompareValues.md)(…) | Compares the values. |
| virtual [GetFromReader](CustomClassField-1/GetFromReader.md)(…) | Gets field value from a data reader. |
| virtual [ValueFromJson](CustomClassField-1/ValueFromJson.md)(…) | Deserializes this fields value from JSON (2 methods) |

## Remarks

Initializes a new instance of the [`CustomClassField`](CustomClassField-1.md) class.

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* class [TValue](../Serenity.Net.Services/CustomClassField-1.TValue.md)
* **Source:** *[CustomClassField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/CustomClassField.cs)*