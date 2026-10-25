# IScriptBundleBuilder interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for building a script bundle from a list of source files.

```csharp
public interface IScriptBundleBuilder
```

## Members

| name | description |
| --- | --- |
| [BuildBundle](IScriptBundleBuilder/BuildBundle.md)(…) | Builds a dynamic script that concatenates the given JS source files, minimizing the files as configured by [`ScriptBundlingOptions`](./ScriptBundlingOptions.md). |

## See Also

* **Source:** *[IScriptBundleBuilder.cs](https://github.com/serenity-is/Serenity/blob/9a2446d846f519fbbaf51efc2ecb18e288be61be/src/web/Mvc/Bundling/ScriptBundling/IScriptBundleBuilder.cs)*