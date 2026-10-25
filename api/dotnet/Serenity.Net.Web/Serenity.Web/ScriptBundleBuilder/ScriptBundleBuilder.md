# ScriptBundleBuilder constructor

Default implementation of [`IScriptBundleBuilder`](../IScriptBundleBuilder.md).

```csharp
public ScriptBundleBuilder(IOptions<ScriptBundlingOptions> options, IScriptMinifier scriptMinifier, 
    IDynamicScriptManager scriptManager, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor? contextAccessor = null, ILogger<ScriptBundleBuilder>? logger = null)
```

| parameter | description |
| --- | --- |
| options | The script bundling options. |
| scriptMinifier | The script minifier. |
| scriptManager | The dynamic script manager. |
| hostEnvironment | The web host environment. |
| contextAccessor | The HTTP context accessor. |
| logger | The logger. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## Remarks

Initializes a new instance of the [`ScriptBundleBuilder`](../ScriptBundleBuilder.md) class.

## See Also

* class [ScriptBundlingOptions](../ScriptBundlingOptions.md)
* interface [IScriptMinifier](../IScriptMinifier.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* class [ScriptBundleBuilder](../ScriptBundleBuilder.md)