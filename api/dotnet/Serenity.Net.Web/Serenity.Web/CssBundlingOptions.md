# CssBundlingOptions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Options for css bundling

```csharp
public class CssBundlingOptions : IOptions<CssBundlingOptions>
```

## Public Members

| name | description |
| --- | --- |
| [CssBundlingOptions](CssBundlingOptions/CssBundlingOptions.md)() | Creates a new instance of the class |
| [Bundles](CssBundlingOptions/Bundles.md) { get; set; } | Gets / sets the list of bundles and their contents |
| [Enabled](CssBundlingOptions/Enabled.md) { get; set; } | Gets / sets if CSS bundling is enabled |
| [Minimize](CssBundlingOptions/Minimize.md) { get; set; } | Gets / sets the minimization flag. When true, CSS files are minified and their minified versions are used in bundles etc. |
| [NoMinimize](CssBundlingOptions/NoMinimize.md) { get; set; } | A list of relative paths to not minify |
| [Replacements](CssBundlingOptions/Replacements.md) { get; set; } | Replacement dictionary for placeholders in bundle contents, like {Development} etc. |
| [UseMinCSS](CssBundlingOptions/UseMinCSS.md) { get; set; } | Should a ".min.css" file that exists in file system be used if available, instead of minifiying the file in memory. |
| [Value](CssBundlingOptions/Value.md) { get; } | Returns this object. |
| const [SectionKey](CssBundlingOptions/SectionKey.md) | Default section key for this option class |

## See Also

* **Source:** *[CssBundlingOptions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/CssBundlingOptions.cs)*