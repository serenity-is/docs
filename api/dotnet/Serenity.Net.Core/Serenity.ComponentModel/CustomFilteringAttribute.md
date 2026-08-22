# CustomFilteringAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class from which other custom filtering types derive.

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class CustomFilteringAttribute : FilteringTypeAttribute
```

| parameter | description |
| --- | --- |
| filteringType | Type of the filtering. |

## Public Members

| name | description |
| --- | --- |
| override [SetParams](CustomFilteringAttribute/SetParams.md)(…) | Sets the parameters. |

## Protected Members

| name | description |
| --- | --- |
| [CustomFilteringAttribute](CustomFilteringAttribute/CustomFilteringAttribute.md)(…) | Base class from which other custom filtering types derive. |
| [GetOption&lt;TType&gt;](CustomFilteringAttribute/GetOption.md)(…) | Gets the option. |
| [SetOption](CustomFilteringAttribute/SetOption.md)(…) | Sets the option. |

## Remarks

Initializes a new instance of the [`CustomFilteringAttribute`](CustomFilteringAttribute.md) class.

## See Also

* class [FilteringTypeAttribute](FilteringTypeAttribute.md)
* **Source:** *[CustomFilteringAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/Columns/Filtering/CustomFilteringAttribute.cs)*