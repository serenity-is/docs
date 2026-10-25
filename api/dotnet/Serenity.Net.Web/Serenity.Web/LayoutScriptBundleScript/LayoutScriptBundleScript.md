# LayoutScriptBundleScript constructor

A predefined dynamic script bundle that concatenates the layout JS files declared with [`LayoutScriptFileAttribute`](../LayoutScriptFileAttribute.md). It is registered under [`ScriptName`](./ScriptName.md) at startup, so it can be referenced from a bundle definition (e.g. `dynamic://Bundle.LayoutScriptFiles`) or rendered with `@Html.Script("dynamic://Bundle.LayoutScriptFiles")`.

```csharp
public LayoutScriptBundleScript(ILayoutScriptFileProvider fileProvider, 
    IScriptBundleBuilder bundleBuilder)
```

| parameter | description |
| --- | --- |
| fileProvider | The layout script file provider. |
| bundleBuilder | The script bundle builder. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |

## Remarks

Unlike `Html.LayoutScriptFiles()`, the file set is resolved by [`GetFiles`](../ILayoutScriptFileProvider/GetFiles.md) the first time the script is generated and then cached, so it does not change dynamically when feature toggles change at runtime. Use `Html.LayoutScriptFiles()` when the file set should follow feature toggles per request. Initializes a new instance of the [`LayoutScriptBundleScript`](../LayoutScriptBundleScript.md) class.

## See Also

* interface [ILayoutScriptFileProvider](../ILayoutScriptFileProvider.md)
* interface [IScriptBundleBuilder](../IScriptBundleBuilder.md)
* class [LayoutScriptBundleScript](../LayoutScriptBundleScript.md)