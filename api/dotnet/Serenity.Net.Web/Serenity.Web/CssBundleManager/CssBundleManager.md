# CssBundleManager constructor

Initializes a new instance of the [`CssBundleManager`](../CssBundleManager.md) class.

```csharp
public CssBundleManager(IOptions<CssBundlingOptions> options, IDynamicScriptManager scriptManager, 
    ICssBundleBuilder bundleBuilder, IWebHostEnvironment hostEnvironment, 
    IHttpContextAccessor? contextAccessor = null)
```

| parameter | description |
| --- | --- |
| options | The options. |
| scriptManager | The dynamic script manager. |
| bundleBuilder | The CSS bundle builder. |
| hostEnvironment | The web host environment. |
| contextAccessor | The HTTP context accessor. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## See Also

* class [CssBundlingOptions](../CssBundlingOptions.md)
* interface [IDynamicScriptManager](../IDynamicScriptManager.md)
* interface [ICssBundleBuilder](../ICssBundleBuilder.md)
* class [CssBundleManager](../CssBundleManager.md)