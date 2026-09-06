# ScriptBundlingOptions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Options for script bundling.

```csharp
public class ScriptBundlingOptions : IOptions<ScriptBundlingOptions>
```

## Public Members

| name | description |
| --- | --- |
| [ScriptBundlingOptions](ScriptBundlingOptions/ScriptBundlingOptions.md)() | Initializes a new instance of the [`ScriptBundlingOptions`](./ScriptBundlingOptions.md) class. |
| [Bundles](ScriptBundlingOptions/Bundles.md) { get; } | Gets the list of bundles and their contents. |
| [Enabled](ScriptBundlingOptions/Enabled.md) { get; set; } | Gets or sets whether script bundling is enabled. |
| [Minimize](ScriptBundlingOptions/Minimize.md) { get; set; } | Gets or sets the minimization flag. When `true`, script files are minified and their minified versions are used in bundles. |
| [NoMinimize](ScriptBundlingOptions/NoMinimize.md) { get; set; } | Gets or sets a list of relative paths to not minify. |
| [Replacements](ScriptBundlingOptions/Replacements.md) { get; } | Gets the replacement dictionary for placeholders in bundle contents, like `{Development}`. |
| [UseMinJS](ScriptBundlingOptions/UseMinJS.md) { get; set; } | Gets or sets whether a `.min.js` file that exists in the file system should be used if available, instead of minifying the file in memory. |
| [Value](ScriptBundlingOptions/Value.md) { get; } | Returns this object. |
| const [SectionKey](ScriptBundlingOptions/SectionKey.md) | The default section key for this option class. |

## See Also

* **Source:** *[ScriptBundlingOptions.cs](https://github.com/serenity-is/Serenity/blob/a5013fdf777dbbd87589205ddffcb67f18bea673/src/web/Mvc/ScriptBundlingOptions.cs)*