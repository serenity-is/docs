# OriginAttribute class
**namespace:** *[Serenity.Data.Mapping](../README.md#serenity.data.mapping-namespace)*   **assembly**: *[Serenity.Net.Data](../README.md)*

Specifies that this column belongs to another table.

```csharp
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, Inherited = false)]
public class OriginAttribute : Attribute
```

## Public Members

| name | description |
| --- | --- |
| [OriginAttribute](OriginAttribute/OriginAttribute.md)(…) | Initializes a new instance of the [`OriginAttribute`](OriginAttribute.md) class. (2 constructors) |
| [Join](OriginAttribute/Join.md) { get; } | Gets the join alias or the property name of the field to read join alias from via LeftJoin attribute. |
| [Property](OriginAttribute/Property.md) { get; set; } | Gets or sets the property. |

## See Also

* **Source:** *[OriginAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Data/Mapping/OriginAttribute.cs)*