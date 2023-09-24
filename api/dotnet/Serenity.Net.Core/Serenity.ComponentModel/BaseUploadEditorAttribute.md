# BaseUploadEditorAttribute class
**namespace:** *[Serenity.ComponentModel](../README.md#serenity.componentmodel-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Sets editor type as "ImageUpload", which only allows image files. Make sure you use this attribute in Row.cs, not Form.cs as the image upload behavior only works if it is in row, otherwise your files will stay in temporary directory.

```csharp
[AttributeUsage(AttributeTargets.All)]
public abstract class BaseUploadEditorAttribute : CustomEditorAttribute, IUploadEditor, 
    IUploadFileConstraints, IUploadFileOptions, IUploadImageContrains, IUploadImageOptions
```

## Public Members

| name | description |
| --- | --- |
| [AllowedExtensions](BaseUploadEditorAttribute/AllowedExtensions.md) { get; set; } |  |
| [AllowNonImage](BaseUploadEditorAttribute/AllowNonImage.md) { get; set; } |  |
| [CopyToHistory](BaseUploadEditorAttribute/CopyToHistory.md) { get; set; } |  |
| [DisableDefaultBehavior](BaseUploadEditorAttribute/DisableDefaultBehavior.md) { get; set; } |  |
| [DisplayFileName](BaseUploadEditorAttribute/DisplayFileName.md) { get; set; } |  |
| [FilenameFormat](BaseUploadEditorAttribute/FilenameFormat.md) { get; set; } |  |
| [IgnoreEmptyImage](BaseUploadEditorAttribute/IgnoreEmptyImage.md) { get; set; } |  |
| [IgnoreExtensionMismatch](BaseUploadEditorAttribute/IgnoreExtensionMismatch.md) { get; set; } |  |
| [IgnoreInvalidImage](BaseUploadEditorAttribute/IgnoreInvalidImage.md) { get; set; } |  |
| [ImageExtensions](BaseUploadEditorAttribute/ImageExtensions.md) { get; set; } |  |
| abstract [IsMultiple](BaseUploadEditorAttribute/IsMultiple.md) { get; } |  |
| [JsonEncodeValue](BaseUploadEditorAttribute/JsonEncodeValue.md) { get; set; } |  |
| [MaxHeight](BaseUploadEditorAttribute/MaxHeight.md) { get; set; } |  |
| [MaxSize](BaseUploadEditorAttribute/MaxSize.md) { get; set; } |  |
| [MaxWidth](BaseUploadEditorAttribute/MaxWidth.md) { get; set; } |  |
| [MinHeight](BaseUploadEditorAttribute/MinHeight.md) { get; set; } |  |
| [MinSize](BaseUploadEditorAttribute/MinSize.md) { get; set; } |  |
| [MinWidth](BaseUploadEditorAttribute/MinWidth.md) { get; set; } |  |
| [OriginalNameProperty](BaseUploadEditorAttribute/OriginalNameProperty.md) { get; set; } |  |
| [ScaleBackColor](BaseUploadEditorAttribute/ScaleBackColor.md) { get; set; } |  |
| [ScaleHeight](BaseUploadEditorAttribute/ScaleHeight.md) { get; set; } |  |
| [ScaleMode](BaseUploadEditorAttribute/ScaleMode.md) { get; set; } |  |
| [ScaleQuality](BaseUploadEditorAttribute/ScaleQuality.md) { get; set; } |  |
| [ScaleSmaller](BaseUploadEditorAttribute/ScaleSmaller.md) { get; set; } |  |
| [ScaleWidth](BaseUploadEditorAttribute/ScaleWidth.md) { get; set; } |  |
| [ThumbBackColor](BaseUploadEditorAttribute/ThumbBackColor.md) { get; set; } |  |
| [ThumbHeight](BaseUploadEditorAttribute/ThumbHeight.md) { get; set; } |  |
| [ThumbMode](BaseUploadEditorAttribute/ThumbMode.md) { get; set; } |  |
| [ThumbQuality](BaseUploadEditorAttribute/ThumbQuality.md) { get; set; } |  |
| [ThumbSizes](BaseUploadEditorAttribute/ThumbSizes.md) { get; set; } |  |
| [ThumbWidth](BaseUploadEditorAttribute/ThumbWidth.md) { get; set; } |  |
| [UploadIntent](BaseUploadEditorAttribute/UploadIntent.md) { get; set; } |  |

## Protected Members

| name | description |
| --- | --- |
| [BaseUploadEditorAttribute](BaseUploadEditorAttribute/BaseUploadEditorAttribute.md)(…) | Initializes a new instance of the [`ImageUploadEditorAttribute`](ImageUploadEditorAttribute.md) class. |

## See Also

* class [CustomEditorAttribute](CustomEditorAttribute.md)
* interface [IUploadEditor](IUploadEditor.md)
* interface [IUploadFileConstraints](IUploadFileConstraints.md)
* interface [IUploadFileOptions](IUploadFileOptions.md)
* interface [IUploadImageContrains](IUploadImageContrains.md)
* interface [IUploadImageOptions](IUploadImageOptions.md)
* **Source:** *[BaseUploadEditorAttribute.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/ComponentModel/Upload/BaseUploadEditorAttribute.cs)*