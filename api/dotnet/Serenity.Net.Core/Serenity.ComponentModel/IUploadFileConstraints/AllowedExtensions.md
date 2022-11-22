# IUploadFileConstraints.AllowedExtensions property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Semicolon separated list of allowed file extensions, like ".xlsx;.docx;.jpg" etc. If specified, only allow files with these extensions. This is currently only used by the upload behavior, the editor and temporary upload does not yet use this setting.

```csharp
public string AllowedExtensions { get; }
```

## See Also

* interface [IUploadFileConstraints](../IUploadFileConstraints.md)