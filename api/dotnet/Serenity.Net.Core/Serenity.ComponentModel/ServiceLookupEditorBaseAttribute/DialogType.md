# ServiceLookupEditorBaseAttribute.DialogType property

This property is meaningful when InplaceAdd is true. By default, the dialog type name is determined by the service, e.g. if the service is "Northwind/CustomerCity/List", a dialog class named "Northwind.CustomerCityDialog" is used. If the dialog type is different than the service, set this to the class name, e.g. "MyModule.MyDialog".

```csharp
public string? DialogType { get; set; }
```

## See Also

* class [ServiceLookupEditorBaseAttribute](../ServiceLookupEditorBaseAttribute.md)