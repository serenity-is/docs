# LayoutCssBundleScript constructor

A predefined dynamic CSS bundle that concatenates the layout CSS files declared with [`LayoutCssFileAttribute`](../LayoutCssFileAttribute.md). It is registered under [`ScriptName`](./ScriptName.md) at startup, so it can be referenced from a bundle definition (e.g. `dynamic://CssBundle.LayoutCssFiles`) or rendered with `@Html.Stylesheet("dynamic://CssBundle.LayoutCssFiles")`.

```csharp
public LayoutCssBundleScript(ILayoutCssFileProvider fileProvider, ICssBundleBuilder bundleBuilder)
```

| parameter | description |
| --- | --- |
| fileProvider | The layout CSS file provider. |
| bundleBuilder | The CSS bundle builder. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |

## Remarks

Unlike `Html.LayoutCssFiles()`, the file set is resolved by [`GetFiles`](../ILayoutCssFileProvider/GetFiles.md) the first time the script is generated and then cached, so it does not change dynamically when feature toggles change at runtime. Use `Html.LayoutCssFiles()` when the file set should follow feature toggles per request. Initializes a new instance of the [`LayoutCssBundleScript`](../LayoutCssBundleScript.md) class.

## See Also

* interface [ILayoutCssFileProvider](../ILayoutCssFileProvider.md)
* interface [ICssBundleBuilder](../ICssBundleBuilder.md)
* class [LayoutCssBundleScript](../LayoutCssBundleScript.md)