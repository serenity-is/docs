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
| [Enabled](CssBundlingOptions/Enabled.md) { get; set; } | Gets or sets whether CSS bundling is enabled. |
| [Minimize](CssBundlingOptions/Minimize.md) { get; set; } | Gets or sets the minimization flag. When `true`, CSS files are minified and their minified versions are used in bundles. |
| [NoMinimize](CssBundlingOptions/NoMinimize.md) { get; set; } | Gets or sets a list of relative paths to not minify. |
| [Replacements](CssBundlingOptions/Replacements.md) { get; set; } | Gets or sets the replacement dictionary for placeholders in bundle contents, like `{Development}`. |
| [UseMinCSS](CssBundlingOptions/UseMinCSS.md) { get; set; } | Gets or sets whether a `.min.css` file that exists in the file system should be used if available, instead of minifying the file in memory. |
| [Value](CssBundlingOptions/Value.md) { get; } | Returns this object. |
| const [SectionKey](CssBundlingOptions/SectionKey.md) | The default section key for this option class. |

## See Also

* **Source:** *[CssBundlingOptions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Mvc/CssBundlingOptions.cs)*