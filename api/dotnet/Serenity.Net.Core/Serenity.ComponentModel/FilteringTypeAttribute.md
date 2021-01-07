# FilteringTypeAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets filtering type for the field

```csharp
[AttributeUsage(AttributeTargets.All)]
public class FilteringTypeAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [FilteringTypeAttribute](FilteringTypeAttribute/FilteringTypeAttribute.md)(…) | Initializes a new instance of the [`FilteringTypeAttribute`](FilteringTypeAttribute.md) class. |
| [FilteringType](FilteringTypeAttribute/FilteringType.md) { get; } | Gets the type of the filtering. |
| virtual [SetParams](FilteringTypeAttribute/SetParams.md)(…) | Sets the parameters. This is called by filtering system to pass additional parameters / options to the filtering object |

## See Also

* **Source:** *[FilteringTypeAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Filtering/FilteringTypeAttribute.cs)*