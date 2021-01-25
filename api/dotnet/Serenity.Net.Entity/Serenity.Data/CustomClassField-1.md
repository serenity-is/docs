# CustomClassField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Entity](../README.md)*

Base class for custom fields with reference type values

```csharp
public class CustomClassField<TValue> : GenericClassField<TValue>
    where TValue : class
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |

## Public Members

| name | description |
| --- | --- |
| [CustomClassField](CustomClassField-1/CustomClassField.md)(…) | Initializes a new instance of the [`CustomClassField`](CustomClassField-1.md) class. |
| override [Copy](CustomClassField-1/Copy.md)(…) | Copies the specified source. |
| override [GetFromReader](CustomClassField-1/GetFromReader.md)(…) | Gets field value from a data reader. |
| override [IndexCompare](CustomClassField-1/IndexCompare.md)(…) | Compares the field values for two rows for an ascending index sort |
| override [ValueFromJson](CustomClassField-1/ValueFromJson.md)(…) | Deserializes this fields value from JSON |
| override [ValueToJson](CustomClassField-1/ValueToJson.md)(…) | Serializes this fields value to JSON |
| virtual [ValueToJson](CustomClassField-1/ValueToJson.md)(…) | Serializes this fields value to JSON |

## Protected Members

| name | description |
| --- | --- |
| virtual [Clone](CustomClassField-1/Clone.md)(…) | Clones the specified value. |
| virtual [CompareValues](CustomClassField-1/CompareValues.md)(…) | Compares the values. |
| virtual [GetFromReader](CustomClassField-1/GetFromReader.md)(…) | Gets field value from a data reader. |
| virtual [ValueFromJson](CustomClassField-1/ValueFromJson.md)(…) | Deserializes this fields value from JSON |

## See Also

* class [GenericClassField&lt;TValue&gt;](GenericClassField-1.md)
* class [TValue](../Serenity.Net.Entity/CustomClassField-1.TValue.md)
* **Source:** *[CustomClassField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Entity/FieldTypes/CustomClassField.cs)*