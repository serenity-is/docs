# RowEditActionsColumnAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Extensions](../README.md)*

Marks a property as the row edit actions column in a grid editor.

```csharp
[AttributeUsage(AttributeTargets.Property)]
public class RowEditActionsColumnAttribute : Attribute, IIntrinsicPropertyAttributeProvider
```

## Public Members

| name | description |
| --- | --- |
| [RowEditActionsColumnAttribute](RowEditActionsColumnAttribute/RowEditActionsColumnAttribute.md)() | The default constructor. |
| virtual [PropertyAttributes](RowEditActionsColumnAttribute/PropertyAttributes.md) { get; } | The property attributes applied to the edit actions column. |

## See Also

* interface [IIntrinsicPropertyAttributeProvider](../Serenity.Net.Core/../Serenity.Reflection/IIntrinsicPropertyAttributeProvider.md)
* **Source:** *[RowEditActionsColumnAttribute.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/common-features/src/extensions/Modules/GridEditor/RowEditActionsColumnAttribute.cs)*