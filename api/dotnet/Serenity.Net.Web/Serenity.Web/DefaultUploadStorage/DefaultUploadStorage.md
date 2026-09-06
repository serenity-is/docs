# DefaultUploadStorage constructor

Initializes a new instance of the [`DefaultUploadStorage`](../DefaultUploadStorage.md) class.

```csharp
public DefaultUploadStorage(IOptions<UploadSettings> options, 
    IWebHostEnvironment hostEnvironment = null, IDiskUploadFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| options | The upload storage options. |
| hostEnvironment | The web host environment. |
| fileSystem | The file system. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |
| ArgumentException | `Options.Url` or `Options.Path` is empty. |

## See Also

* class [UploadSettings](../../../Serenity.Net.Services/Serenity.Web/UploadSettings.md)
* interface [IDiskUploadFileSystem](../../../Serenity.Net.Services/Serenity.Web/IDiskUploadFileSystem.md)
* class [DefaultUploadStorage](../DefaultUploadStorage.md)