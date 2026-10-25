# LayoutScriptFileOptions class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Options for layout script files declared with [`LayoutScriptFileAttribute`](./LayoutScriptFileAttribute.md).

```csharp
public class LayoutScriptFileOptions
```

## Public Members

| name | description |
| --- | --- |
| [LayoutScriptFileOptions](LayoutScriptFileOptions/LayoutScriptFileOptions.md)() | The default constructor. |
| [Filter](LayoutScriptFileOptions/Filter.md) { get; set; } | Gets or sets an optional filter that can be used to exclude some of the declared layout script files. Returning `false` skips the file. |

## See Also

* **Source:** *[LayoutScriptFileOptions.cs](https://github.com/serenity-is/Serenity/blob/9a2446d846f519fbbaf51efc2ecb18e288be61be/src/web/Mvc/Bundling/LayoutScriptFiles/LayoutScriptFileOptions.cs)*