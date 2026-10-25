# ScriptBundleManager constructor

Initializes a new instance of the [`ScriptBundleManager`](../ScriptBundleManager.md) class.

```csharp
public ScriptBundleManager(IOptions<ScriptBundlingOptions> options, 
    IScriptBundleBuilder bundleBuilder, IDynamicScriptManager scriptManager, 
    IWebHostEnvironment hostEnvironment, IHttpContextAccessor? contextAccessor = null)
```

| parameter | description |
| --- | --- |
| options | The options. |
| bundleBuilder | The script bundle builder. |
| scriptManager | The dynamic script manager. |
| hostEnvironment | The web host environment. |
| contextAccessor | The HTTP context accessor. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## See Also

* class [ScriptBundlingOptions](../ScriptBundlingOptions.md)
* interface [IScriptBundleBuilder](../IScriptBundleBuilder.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* class [ScriptBundleManager](../ScriptBundleManager.md)