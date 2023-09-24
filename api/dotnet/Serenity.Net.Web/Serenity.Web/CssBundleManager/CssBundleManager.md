# CssBundleManager constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates an instance of the class

```csharp
public CssBundleManager(IOptions<CssBundlingOptions> options, IDynamicScriptManager scriptManager, 
    ICssMinifier cssMinifier, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor contextAccessor = null, ILogger<CssBundleManager> logger = null)
```

| parameter | description |
| --- | --- |
| options | Options |
| scriptManager | Dynamic script manager |
| cssMinifier |  |
| hostEnvironment | Web host environment |
| contextAccessor | HTTP context accessor |
| logger | Exception logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException |  |

## See Also

* class [CssBundlingOptions](../CssBundlingOptions.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ICssMinifier](../ICssMinifier.md)
* class [CssBundleManager](../CssBundleManager.md)