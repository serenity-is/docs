# ICssBundleManager interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for a CSS bundling manager.

```csharp
public interface ICssBundleManager
```

## Members

| name | description |
| --- | --- |
| [IsEnabled](ICssBundleManager/IsEnabled.md) { get; } | Returns `true` if bundling is enabled. |
| [CssChanged](ICssBundleManager/CssChanged.md)() | A method that can be called to clear the CSS file cache. |
| [GetBundleIncludes](ICssBundleManager/GetBundleIncludes.md)(…) | Gets the list of bundle includes. |
| [GetCssBundle](ICssBundleManager/GetCssBundle.md)(…) | Gets the CSS bundle containing a CSS URL. |
| [Reset](ICssBundleManager/Reset.md)() | Resets the CSS bundle manager. |

## See Also

* **Source:** *[ICssBundleManager.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Mvc/ICssBundleManager.cs)*