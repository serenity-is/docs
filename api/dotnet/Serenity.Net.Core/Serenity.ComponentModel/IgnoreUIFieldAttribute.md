# IgnoreUIFieldAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Skips a property while generating grid column, form field, or report form parameter list. Use this to ignore a property for UI, but still use it for other purposes like JSON serialization. This might be useful for example when a type is used as a Service Request and Form Declaration at the same time. Unlike TransformIgnoreAttribute, this will generate the property in request types, but skip it in UI generation.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class IgnoreUIFieldAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [IgnoreUIFieldAttribute](IgnoreUIFieldAttribute/IgnoreUIFieldAttribute.md)() | The default constructor. |

## See Also

* **Source:** *[IgnoreUIFieldAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/IgnoreUIFieldAttribute.cs)*