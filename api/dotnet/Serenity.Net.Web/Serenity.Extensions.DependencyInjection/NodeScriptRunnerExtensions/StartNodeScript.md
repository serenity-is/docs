# NodeScriptRunnerExtensions.StartNodeScript method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Starts a node (NPM) script

```csharp
public static void StartNodeScript(this IApplicationBuilder appBuilder, string scriptName, 
    string arguments = null, string workingDirectory = null, 
    IDictionary<string, string> envVars = null, string pkgManagerCommand = "npm")
```

| parameter | description |
| --- | --- |
| appBuilder | Application builder |
| scriptName | Script name in package.json |
| arguments | Arguments |
| workingDirectory | Working directory |
| envVars | Environment variables |
| pkgManagerCommand | Package manager command (default is "npm") |

## See Also

* class [NodeScriptRunnerExtensions](../NodeScriptRunnerExtensions.md)