# CssBundleBuilder constructor

Default implementation of [`ICssBundleBuilder`](../ICssBundleBuilder.md).

```csharp
public CssBundleBuilder(IOptions<CssBundlingOptions> options, IDynamicScriptManager scriptManager, 
    ICssMinifier cssMinifier, IWebHostEnvironment hostEnvironment, 
    ILogger<CssBundleBuilder>? logger = null)
```

| parameter | description |
| --- | --- |
| options | The CSS bundling options. |
| scriptManager | The dynamic script manager. |
| cssMinifier | The CSS minifier. |
| hostEnvironment | The web host environment. |
| logger | The logger. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## Remarks

Initializes a new instance of the [`CssBundleBuilder`](../CssBundleBuilder.md) class.

## See Also

* class [CssBundlingOptions](../CssBundlingOptions.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ICssMinifier](../ICssMinifier.md)
* class [CssBundleBuilder](../CssBundleBuilder.md)