# NotFilterableAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Indicates that the field this attribute is placed on is not filterable.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class NotFilterableAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | if set to `true` (default) field is not filterable. |

## Public Members

| name | description |
| --- | --- |
| [NotFilterableAttribute](NotFilterableAttribute/NotFilterableAttribute.md)(…) | Indicates that the field this attribute is placed on is not filterable. |
| [Value](NotFilterableAttribute/Value.md) { get; } | Gets a value indicating whether this [`NotFilterableAttribute`](NotFilterableAttribute.md) is enabled. |

## Remarks

Initializes a new instance of the [`NotFilterableAttribute`](NotFilterableAttribute.md) class.

## See Also

* **Source:** *[NotFilterableAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/Columns/Filtering/NotFilterableAttribute.cs)*