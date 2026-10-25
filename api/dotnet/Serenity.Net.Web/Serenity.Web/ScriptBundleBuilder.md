# ScriptBundleBuilder class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Default implementation of [`IScriptBundleBuilder`](./IScriptBundleBuilder.md).

```csharp
public class ScriptBundleBuilder : IScriptBundleBuilder
```

| parameter | description |
| --- | --- |
| options | The script bundling options. |
| scriptMinifier | The script minifier. |
| scriptManager | The dynamic script manager. |
| hostEnvironment | The web host environment. |
| contextAccessor | The HTTP context accessor. |
| logger | The logger. |

## Public Members

| name | description |
| --- | --- |
| [ScriptBundleBuilder](ScriptBundleBuilder/ScriptBundleBuilder.md)(…) | Default implementation of [`IScriptBundleBuilder`](./IScriptBundleBuilder.md). |
| [BuildBundle](ScriptBundleBuilder/BuildBundle.md)(…) |  |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the required arguments is `null`. |

## Remarks

Initializes a new instance of the [`ScriptBundleBuilder`](./ScriptBundleBuilder.md) class.

## See Also

* interface [IScriptBundleBuilder](./IScriptBundleBuilder.md)
* **Source:** *[ScriptBundleBuilder.cs](https://github.com/serenity-is/Serenity/blob/9a2446d846f519fbbaf51efc2ecb18e288be61be/src/web/Mvc/Bundling/ScriptBundling/ScriptBundleBuilder.cs)*