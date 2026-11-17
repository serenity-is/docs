# VisibleWhenAttribute constructor

Shows a field of a form only while another field has one of the values, or has a value when none are given, e.g. `[VisibleWhen(nameof(Action), MyAction.OpenLink)]`, `[VisibleWhen(nameof(ShowTrend))]` for while a checkbox is checked, or `[VisibleWhen(nameof(DateColumn), IsNot = true)]` for while a field is empty.

```csharp
public VisibleWhenAttribute(string field, params object?[] values)
```

| parameter | description |
| --- | --- |
| field | The name of the field whose value is checked, as the form has it, e.g. `nameof(Action)`. |
| values | The values that show the field, any of which the other field can have. When there are none, it is shown while the other field has a value, i.e. it is not empty, and a checkbox while it is checked. |

## Remarks

A condition only hides: a field hidden by [`VisibleAttribute`](../VisibleAttribute.md), a permission, or on insert or update stays hidden. A field hidden by its condition also hides the fields whose conditions are on it, and a category or a tab whose fields are all hidden is hidden too. A hidden field is not validated, e.g. it is not required, and its value is kept, unless [`ClearWhenHidden`](./ClearWhenHidden.md) is set. It is for forms only, not a security boundary.

## See Also

* class [VisibleWhenAttribute](../VisibleWhenAttribute.md)