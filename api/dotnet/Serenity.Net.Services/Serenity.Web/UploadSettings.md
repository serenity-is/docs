# UploadSettings class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Upload settings

```csharp
public class UploadSettings : IOptions<UploadSettings>
```

## Public Members

| name | description |
| --- | --- |
| [UploadSettings](UploadSettings/UploadSettings.md)() | Creates a new instance of the class |
| [Path](UploadSettings/Path.md) { get; set; } | Root path for uploads, default is "App_Data/upload/" |
| [Url](UploadSettings/Url.md) { get; set; } | Root ur for uploads, default is "~/upload" |
| [Value](UploadSettings/Value.md) { get; } | Gets this instance |
| const [SectionKey](UploadSettings/SectionKey.md) | The default section key in appsettings.json |

## See Also

* **Source:** *[UploadSettings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/UploadSettings.cs)*