# ScriptBundleManager constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Initializes a new instance of the [`ScriptBundleManager`](../ScriptBundleManager.md) class.

```csharp
public ScriptBundleManager(IOptions<ScriptBundlingOptions> options, IScriptMinifier scriptMinifier, 
    IDynamicScriptManager scriptManager, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor contextAccessor = null, ILogger<ScriptBundleManager> logger = null)
```

| parameter | description |
| --- | --- |
| options | The options. |
| scriptManager | The dynamic script manager. |
| scriptMinifier | The script minifier. |
| hostEnvironment | The web host environment. |
| contextAccessor | The HTTP context accessor. |
| logger | The logger. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## See Also

* class [ScriptBundlingOptions](../ScriptBundlingOptions.md)
* interface [IScriptMinifier](../IScriptMinifier.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* class [ScriptBundleManager](../ScriptBundleManager.md)