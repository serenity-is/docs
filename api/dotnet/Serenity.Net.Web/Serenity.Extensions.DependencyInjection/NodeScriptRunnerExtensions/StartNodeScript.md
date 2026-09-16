# NodeScriptRunnerExtensions.StartNodeScript method

Starts a node (NPM) script and attaches its output to the application logger.

```csharp
public static void StartNodeScript(this IApplicationBuilder appBuilder, string scriptName, 
    string? arguments = null, string? workingDirectory = null, 
    IDictionary<string, string>? envVars = null, string pkgManagerCommand = "node", 
    Func<ProcessStartInfo, IStartedProcess>? processFactory = null)
```

| parameter | description |
| --- | --- |
| appBuilder | The application builder. |
| scriptName | The script name in `package.json`. |
| arguments | The arguments to pass to the script. |
| workingDirectory | The working directory; defaults to the content root path. |
| envVars | Optional environment variables to set for the process. |
| pkgManagerCommand | The package manager command (defaults to `node`). |
| processFactory | An optional factory used to create the process, mainly for testing. |

## See Also

* interface [IStartedProcess](../../Serenity.Web/IStartedProcess.md)
* class [NodeScriptRunnerExtensions](../NodeScriptRunnerExtensions.md)