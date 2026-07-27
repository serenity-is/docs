# UnboundAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Marks the column / form field as unbound (non-data / UI-only). As it derives from SkipNameCheckAttribute it skips checking the property name when [BasedOnRow] attribute is used. When used on a column property, it will have no field name in the generated column, only a column id. This is useful for columns that do not correspond to actual data fields, such as ones that host action buttons, status indicators etc. When used on a form field property, the form will not try to load or save any value for it, similar to how SkipOnSave / SkipOnLoad works. This can be considered a mixture of [SkipNameCheck] and [SkipOnLoad]/[SkipOnSave].

```csharp
[AttributeUsage(AttributeTargets.All)]
public class UnboundAttribute : SkipNameCheckAttribute
```

## Public Members

| name | description |
| --- | --- |
| [UnboundAttribute](UnboundAttribute/UnboundAttribute.md)() | The default constructor. |

## See Also

* class [SkipNameCheckAttribute](SkipNameCheckAttribute.md)
* **Source:** *[UnboundAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/UnboundAttribute.cs)*