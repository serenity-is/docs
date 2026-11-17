# PropertyCondition class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

A condition on the value of another field of a form, which a field is shown, made read only or required by, see [`VisibleWhenAttribute`](./VisibleWhenAttribute.md), [`ReadOnlyWhenAttribute`](./ReadOnlyWhenAttribute.md) and [`RequiredWhenAttribute`](./RequiredWhenAttribute.md).

```csharp
public class PropertyCondition
```

## Public Members

| name | description |
| --- | --- |
| [PropertyCondition](PropertyCondition/PropertyCondition.md)() | The default constructor. |
| [Field](PropertyCondition/Field.md) { get; set; } | Gets or sets the name of the field whose value is checked, as the form has it, e.g. a property name. |
| [IsNot](PropertyCondition/IsNot.md) { get; set; } | Gets or sets whether the condition is the opposite, e.g. met when the field has none of the values, or has no value. |
| [Values](PropertyCondition/Values.md) { get; set; } | Gets or sets the values that meet the condition, any of which the field can have. When there are none, the condition is met when the field has a value, which is one that is not null, an empty string, an empty list or false. Enum values are given as their numbers, as the editors have them. |
| [IsMet](PropertyCondition/IsMet.md)(…) | Gets whether a value meets the condition, by the same rules as the forms: a value matches one of the values when they are the same as text, e.g. 2 and "2", or true and "true", and a list matches when any of its items does. It can be used to check on the server what a form checks, e.g. that a field required by a condition has a value. |
| static [HasValue](PropertyCondition/HasValue.md)(…) | Gets whether a value is one, i.e. it is not null, an empty string, an empty list or false. |
| static [ToText](PropertyCondition/ToText.md)(…) | Gets the text a value is compared by, as the forms compare them: enum values by their numbers, booleans as true and false, and numbers in the invariant culture. |

## See Also

* **Source:** *[PropertyCondition.cs](https://github.com/serenity-is/Serenity/blob/1eb5158a5895d86fdddd7c94fd72a6f645432cb5/src/core/ComponentModel/PropertyGrid/PropertyCondition.cs)*