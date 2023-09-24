# ScriptBundleManager constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a new instance of the class

```csharp
public ScriptBundleManager(IOptions<ScriptBundlingOptions> options, IScriptMinifier scriptMinifier, 
    IDynamicScriptManager scriptManager, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor contextAccessor = null, ILogger<ScriptBundleManager> logger = null)
```

| parameter | description |
| --- | --- |
| options | Options |
| scriptManager | Dynamic script manager |
| scriptMinifier | Script minifier |
| hostEnvironment | Web host environment |
| contextAccessor | HTTP context accessor |
| logger | Logger |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of arguments is null |

## See Also

* class [ScriptBundlingOptions](../ScriptBundlingOptions.md)
* interface [IScriptMinifier](../IScriptMinifier.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* class [ScriptBundleManager](../ScriptBundleManager.md)