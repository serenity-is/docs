# SkipOnLoadAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should not get read from the source entity when a form or grid is loading. This means, the editor of the property saves the value to the entity on save, but it doesn't get read back from it when loading first time or refreshing. Useful for properties that should retain editor state without syncing to the entity on load.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class SkipOnLoadAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [SkipOnLoadAttribute](SkipOnLoadAttribute/SkipOnLoadAttribute.md)() | The default constructor. |

## See Also

* **Source:** *[SkipOnLoadAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/SkipOnLoadAttribute.cs)*