# ComparerAttribute class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Specifies the comparer used to compare the values of a row's fields (for example, for change detection or dirty tracking). Can be applied to a row class to affect all of its fields, or to a single field property to override the row, connection or global setting.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public class ComparerAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [ComparerAttribute](ComparerAttribute/ComparerAttribute.md)(…) | Initializes a new instance using a StringComparison value. (3 constructors) |
| [CaseInsensitive](ComparerAttribute/CaseInsensitive.md) { get; } | Gets a value indicating whether to compare case-insensitively. |
| [Comparison](ComparerAttribute/Comparison.md) { get; } | Gets the string comparison, if specified. |
| [Culture](ComparerAttribute/Culture.md) { get; } | Gets the culture name, if specified. |
| [ToStringComparer](ComparerAttribute/ToStringComparer.md)() | Creates the StringComparer represented by this attribute. |

## See Also

* **Source:** *[ComparerAttribute.cs](https://github.com/serenity-is/Serenity/blob/f828b609b385564332aeeec6f0d6a031cde4142f/src/services/Data/Mapping/ComparerAttribute.cs)*