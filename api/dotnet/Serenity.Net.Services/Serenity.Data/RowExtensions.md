# RowExtensions class
**namespace:** *[Serenity.Data](../README.md#serenity.data-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains extensions for row objects.

```csharp
public static class RowExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [ApplyDefaultValues&lt;TRow&gt;](RowExtensions/ApplyDefaultValues.md)(…) | Applies the default values. |
| static [Clone&lt;TRow&gt;](RowExtensions/Clone.md)(…) | Clones the specified row. |
| static [FindField](RowExtensions/FindField.md)(…) | Finds a field by its column or field name. |
| static [FindFieldByPropertyName](RowExtensions/FindFieldByPropertyName.md)(…) | Finds a field by its C# property name. |
| static [FindFieldByPropertyOrFieldName](RowExtensions/FindFieldByPropertyOrFieldName.md)(…) | Finds a field by its C# property name, falling back to its column or field name. |
| static [FindFieldByPublicName](RowExtensions/FindFieldByPublicName.md)(…) | Finds a field by its public name: its C# property name, or its field name when it has no corresponding property. |
| static [GetFields](RowExtensions/GetFields.md)(…) | Gets the fields. |
| static [GetIdField](RowExtensions/GetIdField.md)(…) | Returns Row's IdField. If row's IdField is null it throws. |

## See Also

* **Source:** *[RowExtensions.cs](https://github.com/serenity-is/Serenity/blob/e229a31867e6332a8e9332cdb032ca8f6c24f2a2/src/services/Entity/Extensions/RowExtensions.cs)*