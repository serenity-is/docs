# LookupEditorBaseAttribute.DialogType property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

This property is meaningful when InplaceAdd is true. By default, dialog type name is determined by LookupKey, e.g. if lookup key is "Northwind.CustomerCity", a dialog class named "Northwind.CustomerCityDialog" is used. If dialog type is different than lookup key, set this to classname, e.g. "MyModule.MyDialog"

```csharp
public string DialogType { get; set; }
```

## See Also

* class [LookupEditorBaseAttribute](../LookupEditorBaseAttribute.md)