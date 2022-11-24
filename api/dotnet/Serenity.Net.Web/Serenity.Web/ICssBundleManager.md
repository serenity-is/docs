# ICssBundleManager interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for css bundling manager

```csharp
public interface ICssBundleManager
```

## Members

| name | description |
| --- | --- |
| [IsEnabled](ICssBundleManager/IsEnabled.md) { get; } | Returns true if bundling is enabled |
| [CssChanged](ICssBundleManager/CssChanged.md)() | A method that can be called to clear css file cache |
| [GetBundleIncludes](ICssBundleManager/GetBundleIncludes.md)(…) | Gets the list of bundle includes |
| [GetCssBundle](ICssBundleManager/GetCssBundle.md)(…) | Gets the CSS bundle containing a css url |
| [Reset](ICssBundleManager/Reset.md)() | Resets the css bundle manager |

## See Also

* **Source:** *[ICssBundleManager.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/ICssBundleManager.cs)*