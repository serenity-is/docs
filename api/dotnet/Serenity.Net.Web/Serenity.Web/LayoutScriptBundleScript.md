# LayoutScriptBundleScript class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

A predefined dynamic script bundle that concatenates the layout JS files declared with [`LayoutScriptFileAttribute`](./LayoutScriptFileAttribute.md). It is registered under [`ScriptName`](./LayoutScriptBundleScript/ScriptName.md) at startup, so it can be referenced from a bundle definition (e.g. `dynamic://Bundle.LayoutScriptFiles`) or rendered with `@Html.Script("dynamic://Bundle.LayoutScriptFiles")`.

```csharp
public class LayoutScriptBundleScript : DynamicScript
```

| parameter | description |
| --- | --- |
| fileProvider | The layout script file provider. |
| bundleBuilder | The script bundle builder. |

## Public Members

| name | description |
| --- | --- |
| [LayoutScriptBundleScript](LayoutScriptBundleScript/LayoutScriptBundleScript.md)(…) | A predefined dynamic script bundle that concatenates the layout JS files declared with [`LayoutScriptFileAttribute`](./LayoutScriptFileAttribute.md). It is registered under [`ScriptName`](./LayoutScriptBundleScript/ScriptName.md) at startup, so it can be referenced from a bundle definition (e.g. `dynamic://Bundle.LayoutScriptFiles`) or rendered with `@Html.Script("dynamic://Bundle.LayoutScriptFiles")`. |
| override [GetScript](LayoutScriptBundleScript/GetScript.md)() |  |
| const [ScriptName](LayoutScriptBundleScript/ScriptName.md) | The predefined registration name of the layout script bundle. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |

## Remarks

Unlike `Html.LayoutScriptFiles()`, the file set is resolved by [`GetFiles`](./ILayoutScriptFileProvider/GetFiles.md) the first time the script is generated and then cached, so it does not change dynamically when feature toggles change at runtime. Use `Html.LayoutScriptFiles()` when the file set should follow feature toggles per request. Initializes a new instance of the [`LayoutScriptBundleScript`](./LayoutScriptBundleScript.md) class.

## See Also

* class [DynamicScript](../../Serenity.Net.Services/Serenity.Web/DynamicScript.md)
* **Source:** *[LayoutScriptBundleScript.cs](https://github.com/serenity-is/Serenity/blob/9a2446d846f519fbbaf51efc2ecb18e288be61be/src/web/Mvc/Bundling/LayoutScriptFiles/LayoutScriptBundleScript.cs)*