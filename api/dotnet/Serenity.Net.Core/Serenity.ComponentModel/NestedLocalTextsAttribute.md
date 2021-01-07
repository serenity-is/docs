# NestedLocalTextsAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that this class contains local texts with optionally subclasses that also contains local texts with keys joined by "." between each class name. The topmost class has no local text prefix by default and its name doesn't take role in local text key generation.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class NestedLocalTextsAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [NestedLocalTextsAttribute](NestedLocalTextsAttribute/NestedLocalTextsAttribute.md)() | Initializes a new instance of the [`NestedLocalTextsAttribute`](NestedLocalTextsAttribute.md) class. |
| [LanguageID](NestedLocalTextsAttribute/LanguageID.md) { get; set; } | Gets or sets the optional language identifier. |
| [Prefix](NestedLocalTextsAttribute/Prefix.md) { get; set; } | Gets or sets the optional local text prefix. |

## See Also

* **Source:** *[NestedLocalTextsAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Extensibility/NestedLocalTextsAttribute.cs)*