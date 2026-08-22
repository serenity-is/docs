# HideOnUpdateAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Controls whether this field is visible in edit record mode.

```csharp
[AttributeUsage(AttributeTargets.All)]
public class HideOnUpdateAttribute : Attribute
```

| parameter | description |
| --- | --- |
| value | True to hide the field on update. |

## Public Members

| name | description |
| --- | --- |
| [HideOnUpdateAttribute](HideOnUpdateAttribute/HideOnUpdateAttribute.md)(…) | Controls whether this field is visible in edit record mode. |
| [Value](HideOnUpdateAttribute/Value.md) { get; } | Gets a value indicating whether this [`HideOnUpdateAttribute`](HideOnUpdateAttribute.md) is on. |

## Remarks

When placed on a field, this attribute controls whether the field is hidden when editing an existing record.

## See Also

* **Source:** *[HideOnUpdateAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/core/ComponentModel/PropertyGrid/HideOnUpdateAttribute.cs)*