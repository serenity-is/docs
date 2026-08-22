# SkipOnSaveAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should not get written when a form or grid is saved. This means, the editor of the property reads the value from the entity, but it doesn't get written back to the entity being saved. Useful for read-only or computed properties that shouldn't update the entity.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class SkipOnSaveAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [SkipOnSaveAttribute](SkipOnSaveAttribute/SkipOnSaveAttribute.md)() | The default constructor. |

## See Also

* **Source:** *[SkipOnSaveAttribute.cs](https://github.com/serenity-is/Serenity/blob/aeacad7c72ee3e47d94d27be39e83faa59a75cf1/src/core/ComponentModel/PropertyGrid/SkipOnSaveAttribute.cs)*