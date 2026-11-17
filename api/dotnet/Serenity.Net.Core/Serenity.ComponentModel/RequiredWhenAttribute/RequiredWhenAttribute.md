# RequiredWhenAttribute constructor

Makes a field of a form required while another field has one of the values, or has a value when none are given, e.g. `[RequiredWhen(nameof(Action), MyAction.OpenLink)]`.

```csharp
public RequiredWhenAttribute(string field, params object?[] values)
```

| parameter | description |
| --- | --- |
| field | The name of the field whose value is checked, as the form has it, e.g. `nameof(Action)`. |
| values | The values that make the field required, any of which the other field can have. When there are none, it is required while the other field has a value, i.e. it is not empty, and a checkbox while it is checked. |

## Remarks

A field that is required anyway stays required, and a field that is hidden or read only is not required. Like [`RequiredAttribute`](../RequiredAttribute.md), it is checked by the forms only; a service can check the same with [`IsMet`](../PropertyCondition/IsMet.md), e.g. from [`ToCondition`](../PropertyConditionAttribute/ToCondition.md).

## See Also

* class [RequiredWhenAttribute](../RequiredWhenAttribute.md)