# NodeScriptRunnerExtensions.UseNodeScriptRunner method

Starts node scripts configured in configuration "StartNodeScripts" key as a semicolon separated strings.

```csharp
public static void UseNodeScriptRunner(this IApplicationBuilder appBuilder, 
    string? workingDirectory = null, IDictionary<string, string>? envVars = null, 
    string pkgManagerCommand = "node", 
    Func<ProcessStartInfo, IStartedProcess>? processFactory = null)
```

| parameter | description |
| --- | --- |
| appBuilder | The application builder. |
| workingDirectory | The working directory; defaults to the content root path. |
| envVars | Optional environment variables to set for the process. |
| pkgManagerCommand | The package manager command (defaults to `node`). |
| processFactory | An optional factory used to create the process, mainly for testing. |

## See Also

* interface [IStartedProcess](../../Serenity.Web/IStartedProcess.md)
* class [NodeScriptRunnerExtensions](../NodeScriptRunnerExtensions.md)