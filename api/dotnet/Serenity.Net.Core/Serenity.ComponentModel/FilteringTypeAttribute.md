# FilteringTypeAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets filtering type for the field

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FilteringTypeAttribute : Attribute
```

| parameter | description |
| --- | --- |
| type | The type. |

## Public Members

| name | description |
| --- | --- |
| [FilteringTypeAttribute](FilteringTypeAttribute/FilteringTypeAttribute.md)(…) | Sets filtering type for the field |
| [FilteringType](FilteringTypeAttribute/FilteringType.md) { get; } | Gets the type of the filtering. |
| virtual [SetParams](FilteringTypeAttribute/SetParams.md)(…) | Sets the parameters. This is called by filtering system to pass additional parameters / options to the filtering object |

## Remarks

Initializes a new instance of the [`FilteringTypeAttribute`](FilteringTypeAttribute.md) class.

## See Also

* **Source:** *[FilteringTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Filtering/FilteringTypeAttribute.cs)*