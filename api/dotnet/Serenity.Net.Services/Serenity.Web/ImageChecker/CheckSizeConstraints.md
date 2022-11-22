# ImageChecker.CheckSizeConstraints method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Checks an image width and height against size constraints

```csharp
public ImageCheckResult CheckSizeConstraints(int width, int height)
```

| parameter | description |
| --- | --- |
| width | Image width. |
| height | Image height. |

## Return Value

One of ImageCheckResult values. ImageCheckResult.JPEGImage if image size is validated.

## See Also

* enum [ImageCheckResult](../ImageCheckResult.md)
* class [ImageChecker](../ImageChecker.md)