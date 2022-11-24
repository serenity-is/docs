# UploadStorageExtensions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

Extension methods for [`IUploadStorage`](IUploadStorage.md) and related classes

```csharp
public static class UploadStorageExtensions
```

## Public Members

| name | description |
| --- | --- |
| static [CopyTemporaryFile](UploadStorageExtensions/CopyTemporaryFile.md)(…) | Copies a temporary file to its target location |
| static [CreateAdditionalThumbs](UploadStorageExtensions/CreateAdditionalThumbs.md)(…) | Creates additional thumbs if specified in the upload image options, and saves them to the target upload storage |
| static [CreateDefaultThumb](UploadStorageExtensions/CreateDefaultThumb.md)(…) | Creates the default thumbnail for image if the size is provided in the upload image options (ThumbWidth and ThumbHeight &gt;= 0) and saves it to the target upload storage file |
| static [GetOriginalName](UploadStorageExtensions/GetOriginalName.md)(…) | Gets original name of a file |
| static [GetThumbnailUrl](UploadStorageExtensions/GetThumbnailUrl.md)(…) | Gets thumbnail URL for the file path |
| static [ReadAllFileBytes](UploadStorageExtensions/ReadAllFileBytes.md)(…) | Reads all file bytes |
| static [ScaleImage](UploadStorageExtensions/ScaleImage.md)(…) | Scales the temporary image with provided upload image options if required based on the options and saves the result to the target upload storage file |
| static [ScaleImageAndCreateAllThumbs](UploadStorageExtensions/ScaleImageAndCreateAllThumbs.md)(…) |  |
| static [ScaleImageAs](UploadStorageExtensions/ScaleImageAs.md)(…) | Scales an image and saves it to an upload storage file |
| static [SetOriginalName](UploadStorageExtensions/SetOriginalName.md)(…) | Sets original name for a file |

## See Also

* **Source:** *[UploadStorageExtensions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/UploadStorageExtensions.cs)*