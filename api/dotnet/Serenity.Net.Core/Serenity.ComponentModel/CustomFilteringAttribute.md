# CustomFilteringAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Base class which other custom filtering types derive from.

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
| [CustomFilteringAttribute](CustomFilteringAttribute/CustomFilteringAttribute.md)(…) | Base class which other custom filtering types derive from. |
| [GetOption&lt;TType&gt;](CustomFilteringAttribute/GetOption.md)(…) | Gets the option. |
| [SetOption](CustomFilteringAttribute/SetOption.md)(…) | Sets the option. |

## Remarks

Initializes a new instance of the [`CustomFilteringAttribute`](CustomFilteringAttribute.md) class.

## See Also

* class [FilteringTypeAttribute](FilteringTypeAttribute.md)
* **Source:** *[CustomFilteringAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Filtering/CustomFilteringAttribute.cs)*