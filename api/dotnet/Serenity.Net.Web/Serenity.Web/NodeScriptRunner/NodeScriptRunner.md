# NodeScriptRunner constructor
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../../README.md)*

Creates a new instance of the class

```csharp
public NodeScriptRunner(string scriptName, string arguments = null, string workingDirectory = null, 
    IDictionary<string, string> envVars = null, string pkgManagerCommand = "npm", 
    DiagnosticSource diagnosticSource = null, 
    CancellationToken applicationStoppingToken = default(CancellationToken))
```

| parameter | description |
| --- | --- |
| scriptName | Script name |
| arguments | Arguments |
| workingDirectory | Working directory |
| envVars | Environment variables |
| pkgManagerCommand | Package manager command. Defaul is "npm" |
| diagnosticSource | Diagnostics source |
| applicationStoppingToken | Application stopping token |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentException | One of arguments is null |

## See Also

* class [NodeScriptRunner](../NodeScriptRunner.md)