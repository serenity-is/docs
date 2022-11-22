# IUploadImageContrains.IgnoreExtensionMismatch property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

If set to false, the upload behavior raises an error when it detects the extension does not match the actual format of the uploaded file. For example, if the uploaded file is "test.jpg" but it has a "png" image inside it raises an error. Default is true, so such mismatches are ignored

```csharp
public bool IgnoreExtensionMismatch { get; }
```

## See Also

* interface [IUploadImageContrains](../IUploadImageContrains.md)