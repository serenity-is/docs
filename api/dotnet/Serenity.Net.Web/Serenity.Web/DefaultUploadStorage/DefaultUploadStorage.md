# DefaultUploadStorage constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a new instance of the object

```csharp
public DefaultUploadStorage(IOptions<UploadSettings> options, 
    IWebHostEnvironment hostEnvironment = null, IDiskUploadFileSystem fileSystem = null)
```

| parameter | description |
| --- | --- |
| options | Upload storage options |
| hostEnvironment | Web host environment |
| fileSystem | File system |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of arguments is null |
| ArgumentOutOfRangeException | Options.URL or Options.Path is empty |

## See Also

* class [UploadSettings](../Serenity.Net.Services/../UploadSettings.md)
* interface [IDiskUploadFileSystem](../Serenity.Net.Services/../IDiskUploadFileSystem.md)
* class [DefaultUploadStorage](../DefaultUploadStorage.md)