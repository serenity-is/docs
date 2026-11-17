# PropertyConditionAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

The base of the attributes that make a field of a form depend on the value of another field, see [`VisibleWhenAttribute`](./VisibleWhenAttribute.md), [`ReadOnlyWhenAttribute`](./ReadOnlyWhenAttribute.md) and [`RequiredWhenAttribute`](./RequiredWhenAttribute.md). A field can have several of them, which must all be met. A named rule can be made by deriving from one of them, e.g. `public class ForLinkAttribute() : VisibleWhenAttribute(nameof(MyOptions.Action), MyAction.OpenLink) { }`.

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class PropertyConditionAttribute : Attribute
```

| parameter | description |
| --- | --- |
| field | The name of the field whose value is checked, as the form has it, e.g. `nameof(Category)`. |
| values | The values that meet the condition, any of which the field can have. When there are none, the condition is met when the field has a value, i.e. it is not empty, and a checkbox when it is checked. |

## Public Members

| name | description |
| --- | --- |
| [Field](PropertyConditionAttribute/Field.md) { get; } | Gets the name of the field whose value is checked. |
| [IsNot](PropertyConditionAttribute/IsNot.md) { get; set; } | Gets or sets whether the condition is the opposite, e.g. met when the field has none of the values, or has no value. |
| [Values](PropertyConditionAttribute/Values.md) { get; } | Gets the values that meet the condition. When there are none, the condition is met when the field has a value. |
| [ToCondition](PropertyConditionAttribute/ToCondition.md)() | Gets the condition, as it is sent to the forms, with enum values as their numbers, like the editors have them. |

## Protected Members

| name | description |
| --- | --- |
| [PropertyConditionAttribute](PropertyConditionAttribute/PropertyConditionAttribute.md)(…) | The base of the attributes that make a field of a form depend on the value of another field, see [`VisibleWhenAttribute`](./VisibleWhenAttribute.md), [`ReadOnlyWhenAttribute`](./ReadOnlyWhenAttribute.md) and [`RequiredWhenAttribute`](./RequiredWhenAttribute.md). A field can have several of them, which must all be met. A named rule can be made by deriving from one of them, e.g. `public class ForLinkAttribute() : VisibleWhenAttribute(nameof(MyOptions.Action), MyAction.OpenLink) { }`. |

## Remarks

They are for forms only, and are not a security boundary: a request can still have a value for a field that is hidden or read only by a condition, which the permission and the editability attributes, and the service, decide.

## See Also

* **Source:** *[PropertyConditionAttribute.cs](https://github.com/serenity-is/Serenity/blob/1eb5158a5895d86fdddd7c94fd72a6f645432cb5/src/core/ComponentModel/PropertyGrid/PropertyConditionAttribute.cs)*