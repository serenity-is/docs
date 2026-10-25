# CssBundlingOptions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Options for CSS bundling.

```csharp
public class CssBundlingOptions : IOptions<CssBundlingOptions>
```

## Public Members

| name | description |
| --- | --- |
| [CssBundlingOptions](CssBundlingOptions/CssBundlingOptions.md)() | Initializes a new instance of the [`CssBundlingOptions`](./CssBundlingOptions.md) class. |
| [Bundles](CssBundlingOptions/Bundles.md) { get; set; } | Gets or sets the list of bundles and their contents. |
| [DedupImports](CssBundlingOptions/DedupImports.md) { get; set; } | Gets or sets whether a CSS file that is imported multiple times within a bundle should only be embedded once. When `false` (the default, and matching browser behavior), the file is embedded at each import position. When `true`, the first occurrence is embedded and later ones are skipped. |
| [Enabled](CssBundlingOptions/Enabled.md) { get; set; } | Gets or sets whether CSS bundling is enabled. |
| [Minimize](CssBundlingOptions/Minimize.md) { get; set; } | Gets or sets the minimization flag. When `true`, CSS files are minified and their minified versions are used in bundles. |
| [NoMinimize](CssBundlingOptions/NoMinimize.md) { get; set; } | Gets or sets a list of relative paths to not minify. |
| [ProcessImports](CssBundlingOptions/ProcessImports.md) { get; set; } | Gets or sets whether CSS `@import` statements in bundle source files should be processed and their contents embedded into the bundle. Only plain (non media qualified), relative imports at the start of a file are processed; external, absolute and conditional imports are left as is. Defaults to `true`. Set to `false` to disable import processing entirely. |
| [Replacements](CssBundlingOptions/Replacements.md) { get; set; } | Gets or sets the replacement dictionary for placeholders in bundle contents, like `{Development}`. |
| [UseMinCSS](CssBundlingOptions/UseMinCSS.md) { get; set; } | Gets or sets whether a `.min.css` file that exists in the file system should be used if available, instead of minifying the file in memory. |
| [Value](CssBundlingOptions/Value.md) { get; } | Returns this object. |
| const [SectionKey](CssBundlingOptions/SectionKey.md) | The default section key for this option class. |

## See Also

* **Source:** *[CssBundlingOptions.cs](https://github.com/serenity-is/Serenity/blob/b25593854f2e2d2560030f357d1bb7a1cbd85e65/src/web/Mvc/Bundling/CssBundling/CssBundlingOptions.cs)*