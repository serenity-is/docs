# ScriptBundlingOptions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Options for script bundling

```csharp
public class ScriptBundlingOptions : IOptions<ScriptBundlingOptions>
```

## Public Members

| name | description |
| --- | --- |
| [ScriptBundlingOptions](ScriptBundlingOptions/ScriptBundlingOptions.md)() | Creates a new instance of the class |
| [Bundles](ScriptBundlingOptions/Bundles.md) { get; } | Gets / sets the list of bundles and their contents |
| [Enabled](ScriptBundlingOptions/Enabled.md) { get; set; } | Gets / sets if script bundling is enabled |
| [Minimize](ScriptBundlingOptions/Minimize.md) { get; set; } | Gets / sets the minimization flag. When true, script files are minified and their minified versions are used in bundles etc. |
| [NoMinimize](ScriptBundlingOptions/NoMinimize.md) { get; set; } | A list of relative paths to not minify |
| [Replacements](ScriptBundlingOptions/Replacements.md) { get; } | Replacement dictionary for placeholders in bundle contents, like {Development} etc. |
| [UseMinJS](ScriptBundlingOptions/UseMinJS.md) { get; set; } | Should a ".min.js" file that exists in file system be used if available, instead of minifiying the file in memory. |
| [Value](ScriptBundlingOptions/Value.md) { get; } | Returns this object. |
| const [SectionKey](ScriptBundlingOptions/SectionKey.md) | Default section key for this option class |

## See Also

* **Source:** *[ScriptBundlingOptions.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Web/Mvc/ScriptBundlingOptions.cs)*