# NodeScriptRunner constructor

Initializes a new instance of the [`NodeScriptRunner`](../NodeScriptRunner.md) class.

```csharp
public NodeScriptRunner(string scriptName, string arguments = null, string workingDirectory = null, 
    IDictionary<string, string> envVars = null, string pkgManagerCommand = "node", 
    DiagnosticSource diagnosticSource = null, CancellationToken applicationStoppingToken = default)
```

| parameter | description |
| --- | --- |
| scriptName | The name of the script to run. |
| arguments | The arguments to pass to the script. |
| workingDirectory | The working directory in which to run the script. |
| envVars | Optional environment variables to set for the process. |
| pkgManagerCommand | The package manager command. Defaults to `node`. |
| diagnosticSource | The diagnostics source used to emit start events. |
| applicationStoppingToken | A token that stops the process when the application is shutting down. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentException | One of the required arguments is null or empty. |

## See Also

* class [NodeScriptRunner](../NodeScriptRunner.md)