# IUploadFileConstraints.ImageExtensions property
**namespace:** *[Serenity.ComponentModel](../../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Semicolon separated list of image extensions. The default list is ".gif;.jpg;.jpeg;.png;" If specified, only these set of file extensions are considered as images and thumbnails are only generated for them. This is currently only used at behavior level. The upload editors and temporary upload do not check them yet. Note that if AllowNonImage is false, only these extensions are allowed and only if they contain a valid image.

```csharp
public string ImageExtensions { get; }
```

## See Also

* interface [IUploadFileConstraints](../IUploadFileConstraints.md)