# CssBundleManager constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Initializes a new instance of the [`CssBundleManager`](../CssBundleManager.md) class.

```csharp
public CssBundleManager(IOptions<CssBundlingOptions> options, IDynamicScriptManager scriptManager, 
    ICssMinifier cssMinifier, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor contextAccessor = null, ILogger<CssBundleManager> logger = null)
```

| parameter | description |
| --- | --- |
| options | The options. |
| scriptManager | The dynamic script manager. |
| cssMinifier | The CSS minifier. |
| hostEnvironment | The web host environment. |
| contextAccessor | The HTTP context accessor. |
| logger | The exception logger. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## See Also

* class [CssBundlingOptions](../CssBundlingOptions.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ICssMinifier](../ICssMinifier.md)
* class [CssBundleManager](../CssBundleManager.md)