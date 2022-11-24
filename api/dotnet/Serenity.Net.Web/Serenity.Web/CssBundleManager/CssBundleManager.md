# CssBundleManager constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates an instance of the class

```csharp
public CssBundleManager(IOptions<CssBundlingOptions> options, IDynamicScriptManager scriptManager, 
    IWebHostEnvironment hostEnvironment, IHttpContextAccessor contextAccessor = null, 
    IExceptionLogger logger = null)
```

| parameter | description |
| --- | --- |
| options | Options |
| scriptManager | Dynamic script manager |
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
* interface [IExceptionLogger](../Serenity.Net.Core/../../Serenity.Abstractions/IExceptionLogger.md)
* class [CssBundleManager](../CssBundleManager.md)