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
| [ExtensionBlacklist](UploadSettings/ExtensionBlacklist.md) { get; set; } | List of blacklisted extensions |
| [ExtensionBlacklistExclude](UploadSettings/ExtensionBlacklistExclude.md) { get; set; } | This allows excluding some extensions from ExtensionBlacklist without having to write all the default extensions in ExtensionBlacklist |
| [ExtensionBlacklistInclude](UploadSettings/ExtensionBlacklistInclude.md) { get; set; } | This allows including additional extensions in ExtensionBlacklist without having to write all the default extensions in ExtensionBlacklist |
| [ExtensionWhitelist](UploadSettings/ExtensionWhitelist.md) { get; set; } | List of whitelisted extensions; Even if an extension is in this list, it won't be allowed if it is also in the ExtensionBlacklist |
| [ExtensionWhitelistExclude](UploadSettings/ExtensionWhitelistExclude.md) { get; set; } | This allows excluding some extensions from ExtensionWhitelist without having to write all the default extensions in ExtensionWhitelist |
| [ExtensionWhitelistInclude](UploadSettings/ExtensionWhitelistInclude.md) { get; set; } | This allows including additional extensions to ExtensionWhitelist without overriding all the default extensions in ExtensionWhitelist |
| [Path](UploadSettings/Path.md) { get; set; } | Root path for uploads, default is "App_Data/upload/" |
| [Url](UploadSettings/Url.md) { get; set; } | Root ur for uploads, default is "~/upload" |
| [Value](UploadSettings/Value.md) { get; } | Gets this instance |
| const [SectionKey](UploadSettings/SectionKey.md) | The default section key in appsettings.json |

## See Also

* **Source:** *[UploadSettings.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/UploadSettings.cs)*