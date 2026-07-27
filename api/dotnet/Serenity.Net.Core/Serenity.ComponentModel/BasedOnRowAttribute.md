# BasedOnRowAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

An attribute that indicates this type is based on another row type. Used with form, columns etc. types to map their properties to corresponding property in a row, so that they inherit attributes.

```csharp
[AttributeUsage(AttributeTargets.Class)]
public sealed class BasedOnRowAttribute : Attribute
```

| parameter | description |
| --- | --- |
| rowType | Type of the row. |

## Public Members

| name | description |
| --- | --- |
| [BasedOnRowAttribute](BasedOnRowAttribute/BasedOnRowAttribute.md)(…) | An attribute that indicates this type is based on another row type. Used with form, columns etc. types to map their properties to corresponding property in a row, so that they inherit attributes. |
| [CheckNames](BasedOnRowAttribute/CheckNames.md) { get; set; } | Gets or sets a value indicating whether to check names. If this is true (by default false), if a property name doesn't exactly match a property in the RowType row, Serenity will raise error. In that case you might add [SkipNameCheck] attribute to properties that shouldn't be checked. |
| [RowType](BasedOnRowAttribute/RowType.md) { get; } | Gets the type of the row. |

## Remarks

Initializes a new instance of the [`BasedOnRowAttribute`](BasedOnRowAttribute.md) class.

## See Also

* **Source:** *[BasedOnRowAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/ComponentModel/PropertyGrid/BasedOnRowAttribute.cs)*