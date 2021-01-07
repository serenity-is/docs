# OneWayAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the target property should not get serialized when a property grid is saved. This means, the editor of the property reads the value from the entity, but it doesn't get written back to save entity.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class OneWayAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [OneWayAttribute](OneWayAttribute/OneWayAttribute.md)() | Initializes a new instance of the [`OneWayAttribute`](OneWayAttribute.md) class. |

## See Also

* **Source:** *[OneWayAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/PropertyGrid/OneWayAttribute.cs)*