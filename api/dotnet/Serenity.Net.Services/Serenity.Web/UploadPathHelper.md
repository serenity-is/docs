# UploadPathHelper class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Contains helper functions for upload paths

```csharp
public static class UploadPathHelper
```

## Public Members

| name | description |
| --- | --- |
| const [MetaFileExtension](UploadPathHelper/MetaFileExtension.md) | Represents the file extension used for metadata files. |
| const [SizedThumbFormat](UploadPathHelper/SizedThumbFormat.md) | Represents the format string used to generate a thumbnail size suffix with width and height placeholders. It does not include the file extension. |
| const [TemporaryFilePrefix](UploadPathHelper/TemporaryFilePrefix.md) | Represents the prefix used to identify temporary upload files. |
| const [ThumbBaseSuffix](UploadPathHelper/ThumbBaseSuffix.md) | The thumbnail suffix used for thumbnail images. Does not include file extension. |
| const [ThumbExtension](UploadPathHelper/ThumbExtension.md) | Represents the file extension used for thumbnail images in JPEG format. |
| static [CheckFileNameSecurity](UploadPathHelper/CheckFileNameSecurity.md)(…) | Checks file name security, e.g. it is a relative file (not rooted) that does not contain ".." etc. |
| static [FindAvailableName](UploadPathHelper/FindAvailableName.md)(…) | Finds an available name for a file |
| static [GetThumbnailName](UploadPathHelper/GetThumbnailName.md)(…) | Gets thumb file name |
| static [IsTemporaryFile](UploadPathHelper/IsTemporaryFile.md)(…) | Determines whether the specified file name represents a temporary upload file. |
| static [TryParseThumbSuffix](UploadPathHelper/TryParseThumbSuffix.md)(…) | Tries to parse a thumbnail filename suffix, e.g. it ends with "_t.jpg", or "_tNxN.jpg" where N is a number |

## See Also

* **Source:** *[UploadPathHelper.cs](https://github.com/serenity-is/Serenity/blob/master/src/Services/Upload/UploadPathHelper.cs)*