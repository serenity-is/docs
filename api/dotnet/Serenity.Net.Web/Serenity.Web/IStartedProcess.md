# IStartedProcess interface
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Abstraction for a started system process, so it can be replaced in tests.

```csharp
public interface IStartedProcess
```

## Members

| name | description |
| --- | --- |
| [EnableRaisingEvents](IStartedProcess/EnableRaisingEvents.md) { get; set; } | Gets or sets a value indicating whether the process raises events. |
| [ExitCode](IStartedProcess/ExitCode.md) { get; } | Gets the process exit code. |
| [HasExited](IStartedProcess/HasExited.md) { get; } | Gets whether the process has exited. |
| [StandardError](IStartedProcess/StandardError.md) { get; } | Gets the standard error reader. |
| [StandardInput](IStartedProcess/StandardInput.md) { get; } | Gets the standard input writer. |
| [StandardOutput](IStartedProcess/StandardOutput.md) { get; } | Gets the standard output reader. |
| [Kill](IStartedProcess/Kill.md)(…) | Kills the process. |
| [WaitForExit](IStartedProcess/WaitForExit.md)(…) | Waits for the process to exit. |

## See Also

* **Source:** *[IStartedProcess.cs](https://github.com/serenity-is/Serenity/blob/401a8738b9bbcc8a73ab6d1df38c8572bbe252c4/src/web/NodeScriptRunner/IStartedProcess.cs)*