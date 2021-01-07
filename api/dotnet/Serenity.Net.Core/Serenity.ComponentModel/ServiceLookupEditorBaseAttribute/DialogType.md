# ServiceLookupEditorBaseAttribute.DialogType property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

This property is meaningfull when InplaceAdd is true. By default, dialog type name is determined by service, e.g. if service is "Northwind/CustomerCity/List", a dialog class named "Northwind.CustomerCityDialog" is used. If dialog type is different than the service, set this to classname, e.g. "MyModule.MyDialog"

```csharp
public string DialogType { get; set; }
```

## See Also

* class [ServiceLookupEditorBaseAttribute](../ServiceLookupEditorBaseAttribute.md)