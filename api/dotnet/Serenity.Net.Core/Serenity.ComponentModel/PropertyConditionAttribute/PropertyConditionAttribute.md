# PropertyConditionAttribute constructor

The base of the attributes that make a field of a form depend on the value of another field, see [`VisibleWhenAttribute`](../VisibleWhenAttribute.md), [`ReadOnlyWhenAttribute`](../ReadOnlyWhenAttribute.md) and [`RequiredWhenAttribute`](../RequiredWhenAttribute.md). A field can have several of them, which must all be met. A named rule can be made by deriving from one of them, e.g. `public class ForLinkAttribute() : VisibleWhenAttribute(nameof(MyOptions.Action), MyAction.OpenLink) { }`.

```csharp
protected PropertyConditionAttribute(string field, params object?[] values)
```

| parameter | description |
| --- | --- |
| field | The name of the field whose value is checked, as the form has it, e.g. `nameof(Category)`. |
| values | The values that meet the condition, any of which the field can have. When there are none, the condition is met when the field has a value, i.e. it is not empty, and a checkbox when it is checked. |

## Remarks

They are for forms only, and are not a security boundary: a request can still have a value for a field that is hidden or read only by a condition, which the permission and the editability attributes, and the service, decide.

## See Also

* class [PropertyConditionAttribute](../PropertyConditionAttribute.md)