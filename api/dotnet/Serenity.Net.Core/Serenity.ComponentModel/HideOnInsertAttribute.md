# HideOnInsertAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Controls whether this field is visible in new record mode.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class HideOnInsertAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | True to hide the field on insert. |

## Public Members

| name | description |
| --- | --- |
| [HideOnInsertAttribute](HideOnInsertAttribute/HideOnInsertAttribute.md)(…) | Controls whether this field is visible in new record mode. |
| [Value](HideOnInsertAttribute/Value.md) { get; } | Gets a value indicating whether this [`HideOnInsertAttribute`](HideOnInsertAttribute.md) is on. |

## Remarks

When placed on a field, this attribute controls whether the field is hidden when creating a new record.

## See Also

* **Source:** *[HideOnInsertAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/HideOnInsertAttribute.cs)*