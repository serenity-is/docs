# NodeScriptRunnerExtensions.UseNodeScriptRunner method

Starts node scripts configured in configuration "StartNodeScripts" key as a semicolon separated strings.

```csharp
public static void UseNodeScriptRunner(this IApplicationBuilder appBuilder, 
    string workingDirectory = null, IDictionary<string, string> envVars = null, 
    string pkgManagerCommand = "node")
```

| parameter | description |
| --- | --- |
| appBuilder | The application builder. |
| workingDirectory | The working directory; defaults to the content root path. |
| envVars | Optional environment variables to set for the process. |
| pkgManagerCommand | The package manager command (defaults to `node`). |

## See Also

* class [NodeScriptRunnerExtensions](../NodeScriptRunnerExtensions.md)