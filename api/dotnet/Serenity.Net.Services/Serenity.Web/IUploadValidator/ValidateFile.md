# IUploadValidator.ValidateFile method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Validates file constraints

```csharp
public void ValidateFile(IUploadFileConstraints constraints, Stream stream, string filename, 
    out bool isImageExtension)
```

| parameter | description |
| --- | --- |
| constraints | The file constraints |
| stream | Source stream |
| filename | File name |
| isImageExtension | Returns true if the file extension matches with constraints.ImageExtensions. |

## See Also

* interface [IUploadFileConstraints](../Serenity.Net.Core/../../Serenity.ComponentModel/IUploadFileConstraints.md)
* interface [IUploadValidator](../IUploadValidator.md)