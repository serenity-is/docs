# GenericField&lt;TValue&gt; class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Base generic class for fields with a value

```csharp
public abstract class GenericField<TValue> : Field
```

| parameter | description |
| --- | --- |
| TValue | The type of the value. |
| collection | The collection. |
| type | The type. |
| name | The name. |
| caption | The caption. |
| size | The size. |
| flags | The flags. |
| getValue | The get value. |
| setValue | The set value. |

## Public Members

| name | description |
| --- | --- |
| [Item](GenericField-1/Item.md) { get; set; } | Gets or sets the value of this field with the specified row. |
| override [Copy](GenericField-1/Copy.md)(…) | Copies the specified source. |

## Protected Members

| name | description |
| --- | --- |
| [GenericField](GenericField-1/GenericField.md)(…) | Base generic class for fields with a value |
| [_getValue](GenericField-1/_getValue.md) | The get value |
| [_setValue](GenericField-1/_setValue.md) | The set value |

## Remarks

Initializes a new instance of the [`GenericField`](GenericField-1.md) class.

## See Also

* class [Field](Field.md)
* **Source:** *[GenericField.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Entity/FieldTypes/GenericField.cs)*