# ScriptBundleManager constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a new instance of the class

```csharp
public ScriptBundleManager(IOptions<ScriptBundlingOptions> options, 
    IDynamicScriptManager scriptManager, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor contextAccessor = null, IExceptionLogger logger = null)
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
| ArgumentNullException | One of arguments is null |

## See Also

* class [ScriptBundlingOptions](../ScriptBundlingOptions.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [IExceptionLogger](../Serenity.Net.Core/../../Serenity.Abstractions/IExceptionLogger.md)
* class [ScriptBundleManager](../ScriptBundleManager.md)