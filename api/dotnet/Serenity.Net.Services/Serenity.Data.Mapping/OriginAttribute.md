# OriginAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Specifies that this column belongs to another table.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, Inherited = false)]
public class OriginAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [OriginAttribute](OriginAttribute/OriginAttribute.md)(…) | Initializes a new instance of the [`OriginAttribute`](./OriginAttribute.md) class. (2 constructors) |
| [Join](OriginAttribute/Join.md) { get; } | Gets the join alias or the property name of the field to read join alias from via LeftJoin attribute. |
| [Property](OriginAttribute/Property.md) { get; set; } | Gets or sets the property. |

## See Also

* **Source:** *[OriginAttribute.cs](https://github.com/serenity-is/Serenity/blob/9bdd88fd415201195fde6c80a27910d26410d8c6/src/services/Data/Mapping/OriginAttribute.cs)*