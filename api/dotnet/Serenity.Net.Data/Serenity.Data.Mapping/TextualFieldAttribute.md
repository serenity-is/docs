# TextualFieldAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Determines textual field for this field. This is placed on foreign keys and specifies which field in joined table (view fields in this row that originates from foreign table) should be used for display / filtering.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class TextualFieldAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [TextualFieldAttribute](TextualFieldAttribute/TextualFieldAttribute.md)(…) | Initializes a new instance of the [`TextualFieldAttribute`](TextualFieldAttribute.md) class. |
| [Value](TextualFieldAttribute/Value.md) { get; } | Gets the value. |

## See Also

* **Source:** *[TextualFieldAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/TextualFieldAttribute.cs)*