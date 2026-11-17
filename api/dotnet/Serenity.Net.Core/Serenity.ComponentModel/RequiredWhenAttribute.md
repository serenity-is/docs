# RequiredWhenAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Makes a field of a form required while another field has one of the values, or has a value when none are given, e.g. `[RequiredWhen(nameof(Action), MyAction.OpenLink)]`.

```csharp
[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
public class RequiredWhenAttribute : PropertyConditionAttribute
```

| parameter | description |
| --- | --- |
| field | The name of the field whose value is checked, as the form has it, e.g. `nameof(Action)`. |
| values | The values that make the field required, any of which the other field can have. When there are none, it is required while the other field has a value, i.e. it is not empty, and a checkbox while it is checked. |

## Public Members

| name | description |
| --- | --- |
| [RequiredWhenAttribute](RequiredWhenAttribute/RequiredWhenAttribute.md)(…) | Makes a field of a form required while another field has one of the values, or has a value when none are given, e.g. `[RequiredWhen(nameof(Action), MyAction.OpenLink)]`. |

## Remarks

A field that is required anyway stays required, and a field that is hidden or read only is not required. Like [`RequiredAttribute`](./RequiredAttribute.md), it is checked by the forms only; a service can check the same with [`IsMet`](./PropertyCondition/IsMet.md), e.g. from [`ToCondition`](./PropertyConditionAttribute/ToCondition.md).

## See Also

* class [PropertyConditionAttribute](./PropertyConditionAttribute.md)
* **Source:** *[RequiredWhenAttribute.cs](https://github.com/serenity-is/Serenity/blob/1eb5158a5895d86fdddd7c94fd72a6f645432cb5/src/core/ComponentModel/PropertyGrid/RequiredWhenAttribute.cs)*