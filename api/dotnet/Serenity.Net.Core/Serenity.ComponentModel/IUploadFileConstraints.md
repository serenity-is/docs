# IUploadFileConstraints interface
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Constraints of the uploaded file size.

```csharp
public interface IUploadFileConstraints : IUploadOptions
```

## Members

| name | description |
| --- | --- |
| [AllowedExtensions](IUploadFileConstraints/AllowedExtensions.md) { get; } | Semicolon separated list of allowed file extensions, like ".xlsx;.docx;.jpg" etc. If specified, only allow files with these extensions. This is currently only used by the upload behavior, the editor and temporary upload does not yet use this setting. |
| [AllowNonImage](IUploadFileConstraints/AllowNonImage.md) { get; } | Should non-image uploads be allowed. |
| [ExtensionBlacklist](IUploadFileConstraints/ExtensionBlacklist.md) { get; } | Contains extensions that are considered dangerous / disallowed. Default is ".asax;.compiled;.ascx;.asmx;.aspx;.bat;.cmd;.com;.config;.dll;.jar;.jsp;.htaccess;.htpasswd;.lnk;.php;.ps1;.vbe;.vbs" |
| [ImageExtensions](IUploadFileConstraints/ImageExtensions.md) { get; } | Semicolon separated list of image extensions. The default list is ".gif;.jpg;.jpeg;.png;" If specified, only these set of file extensions are considered as images and thumbnails are only generated for them. This is currently only used at behavior level. The upload editors and temporary upload do not check them yet. Note that if AllowNonImage is false, only these extensions are allowed and only if they contain a valid image. |
| [MaxSize](IUploadFileConstraints/MaxSize.md) { get; } | Maximum size in bytes of the uploaded file. |
| [MinSize](IUploadFileConstraints/MinSize.md) { get; } | Minimum size in bytes of the uploaded file. |

## See Also

* interface [IUploadOptions](IUploadOptions.md)