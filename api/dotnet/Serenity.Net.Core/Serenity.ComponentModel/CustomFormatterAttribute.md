# CustomFormatterAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class for custom formatter type attributes

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class CustomFormatterAttribute : FormatterTypeAttribute
```

## Public Members

| name | description |
| --- | --- |
| [CustomFormatterAttribute](CustomFormatterAttribute/CustomFormatterAttribute.md)(…) | Initializes a new instance of the [`CustomFormatterAttribute`](CustomFormatterAttribute.md) class. |
| override [SetParams](CustomFormatterAttribute/SetParams.md)(…) | Sets the parameters for formatter. |

## Protected Members

| name | description |
| --- | --- |
| [GetOption&lt;TType&gt;](CustomFormatterAttribute/GetOption.md)(…) | Gets value of an option. |
| [SetOption](CustomFormatterAttribute/SetOption.md)(…) | Sets the option. |

## See Also

* class [FormatterTypeAttribute](FormatterTypeAttribute.md)
* **Source:** *[CustomFormatterAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Columns/Formatting/CustomFormatterAttribute.cs)*