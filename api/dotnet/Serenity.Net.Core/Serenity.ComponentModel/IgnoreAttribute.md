# IgnoreAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Skips a property while generating grid column or form field list. Use this to ignore a property for UI, but still use it for other purposes like JSON serialization. This might be useful when a type is used as a Service Request and Form Declaration at the same time.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class IgnoreAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [IgnoreAttribute](IgnoreAttribute/IgnoreAttribute.md)() | The default constructor. |

## See Also

* **Source:** *[IgnoreAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/IgnoreAttribute.cs)*