# IUploadEditor.UploadIntent property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

This is a property used to match uploaded files with their origins. If not specified, will be calculated as: "FullTypeName,AssemblyName:PropertyName" from the attribute this property is placed on. This way the temporary upload processor can locate the original attribute by its type name and validate its settings or generate the expected thumbnail types.

```csharp
public string UploadIntent { get; }
```

## See Also

* interface [IUploadEditor](../IUploadEditor.md)