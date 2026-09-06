# UploadPathHelper.SizedThumbFormat field

Represents the format string used to generate a thumbnail size suffix with width and height placeholders. It does not include the file extension.

```csharp
public const string SizedThumbFormat;
```

## Remarks

This format string can be used with string formatting methods to create a suffix indicating the dimensions of a thumbnail image. For example, using string.Format(SizedThumbFormat, 100, 200) produces the string "_t100x200".

## See Also

* class [UploadPathHelper](../UploadPathHelper.md)