# CustomFormatterAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class for custom formatter type attributes

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class CustomFormatterAttribute : FormatterTypeAttribute
```

| parameter | description |
| --- | --- |
| formatterType | Type of the formatter. |

## Public Members

| name | description |
| --- | --- |
| override [SetParams](CustomFormatterAttribute/SetParams.md)(…) | Sets the parameters for formatter. |

## Protected Members

| name | description |
| --- | --- |
| [CustomFormatterAttribute](CustomFormatterAttribute/CustomFormatterAttribute.md)(…) | Base class for custom formatter type attributes |
| [GetOption&lt;TType&gt;](CustomFormatterAttribute/GetOption.md)(…) | Gets value of an option. |
| [SetOption](CustomFormatterAttribute/SetOption.md)(…) | Sets the option. |

## Remarks

Initializes a new instance of the [`CustomFormatterAttribute`](CustomFormatterAttribute.md) class.

## See Also

* class [FormatterTypeAttribute](FormatterTypeAttribute.md)
* **Source:** *[CustomFormatterAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Formatting/CustomFormatterAttribute.cs)*