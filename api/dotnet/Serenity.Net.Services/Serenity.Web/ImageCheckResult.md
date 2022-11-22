# ImageCheckResult enumeration
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../README.md)*

[`ImageChecker`](ImageChecker.md)'s result codes.

```csharp
public enum ImageCheckResult
```

## Values

| name | value | description |
| --- | --- | --- |
| Valid | `0` | Checked image is OK |
| StreamReadError | `1` | Error occurred during reading |
| DataSizeTooHigh | `2` | File size too high |
| InvalidImage | `3` | Image file is invalid |
| ImageIsEmpty | `4` | Image is empty, its height or width is zero |
| SizeMismatch | `5` | Image is not at exact pixel width/height |
| WidthMismatch | `6` | Image doesn't have an exact width |
| WidthTooHigh | `7` | Image is wider than maximum allowed |
| WidthTooLow | `8` | Image is shorter than minimum allowed |
| HeightMismatch | `9` | Image doesn't have an exact height |
| HeightTooHigh | `10` | Image is taller than maximum allowed |
| HeightTooLow | `11` | Image is shorter than minimum allowed |

## See Also

* **Source:** *[ImageCheckResult.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Services/Upload/ImageCheckResult.cs)*