# ExceptionExtensions.Log method
**namespace:** *[Serenity](../../README.md#serenity-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Logs the exception if logger instance is not null

```csharp
public static void Log(this Exception exception, IExceptionLogger logger, string category = null)
```

| parameter | description |
| --- | --- |
| exception | Exception |
| logger | Logger |
| category | Optional category |

## See Also

* interface [IExceptionLogger](../../Serenity.Abstractions/IExceptionLogger.md)
* class [ExceptionExtensions](../ExceptionExtensions.md)