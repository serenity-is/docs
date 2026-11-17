# ReadOnlyWhenAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Makes a field of a form read only while another field has one of the values, or has a value when none are given, e.g. `[ReadOnlyWhen(nameof(IsLocked))]` for while a checkbox is checked.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class ReadOnlyWhenAttribute : PropertyConditionAttribute
```

| parameter | description |
| --- | --- |
| field | The name of the field whose value is checked, as the form has it, e.g. `nameof(IsLocked)`. |
| values | The values that make the field read only, any of which the other field can have. When there are none, it is read only while the other field has a value, i.e. it is not empty, and a checkbox while it is checked. |

## Public Members

| name | description |
| --- | --- |
| [ReadOnlyWhenAttribute](ReadOnlyWhenAttribute/ReadOnlyWhenAttribute.md)(…) | Makes a field of a form read only while another field has one of the values, or has a value when none are given, e.g. `[ReadOnlyWhen(nameof(IsLocked))]` for while a checkbox is checked. |

## Remarks

A condition only makes a field read only: one that is read only, or not editable by a permission, stays so. It is for forms only, not a security boundary, which [`UpdatableAttribute`](./UpdatableAttribute.md) and the permissions are.

## See Also

* class [PropertyConditionAttribute](./PropertyConditionAttribute.md)
* **Source:** *[ReadOnlyWhenAttribute.cs](https://github.com/serenity-is/Serenity/blob/1eb5158a5895d86fdddd7c94fd72a6f645432cb5/src/core/ComponentModel/PropertyGrid/ReadOnlyWhenAttribute.cs)*