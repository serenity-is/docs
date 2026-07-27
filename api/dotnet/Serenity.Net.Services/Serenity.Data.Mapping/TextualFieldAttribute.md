# TextualFieldAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Determines textual field for this field. This is placed on foreign keys and specifies which field in joined table (view fields in this row that originates from foreign table) should be used for display / filtering.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class TextualFieldAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | The value. |

## Public Members

| name | description |
| --- | --- |
| [TextualFieldAttribute](TextualFieldAttribute/TextualFieldAttribute.md)(…) | Determines textual field for this field. This is placed on foreign keys and specifies which field in joined table (view fields in this row that originates from foreign table) should be used for display / filtering. |
| [Value](TextualFieldAttribute/Value.md) { get; } | Gets the value. |

## Remarks

Initializes a new instance of the [`TextualFieldAttribute`](TextualFieldAttribute.md) class.

## See Also

* **Source:** *[TextualFieldAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Data/Mapping/TextualFieldAttribute.cs)*