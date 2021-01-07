# EnumFormatterAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets formatting type to "Enum".

```csharp
[AttributeUsage(AttributeTargets.All)]
public class EnumFormatterAttribute : CustomFormatterAttribute
```

## Public Members

| name | description |
| --- | --- |
| [EnumFormatterAttribute](EnumFormatterAttribute/EnumFormatterAttribute.md)() | Initializes a new instance of the [`EnumFormatterAttribute`](EnumFormatterAttribute.md) class. |
| [EnumKey](EnumFormatterAttribute/EnumKey.md) { get; set; } | Gets or sets the enum key which is full namespace and class name of the enum or it should match the value set with [EnumKey] attribute on the enum type. |

## See Also

* class [CustomFormatterAttribute](CustomFormatterAttribute.md)
* **Source:** *[BasicFormatterTypes.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Formatting/BasicFormatterTypes.cs)*