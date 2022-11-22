# CommandLineTools.EscapeArguments method
**namespace:** *[Serenity.IO](../../README.md#serenity.io-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Quotes all arguments that contain whitespace, or begin with a quote and returns a single argument string for use with Process.Start().

```csharp
public static string EscapeArguments(params string[] args)
```

| parameter | description |
| --- | --- |
| args | A list of strings for arguments, may not contain null, '\0', '\r', or '\n' |

## Return Value

The combined list of escaped/quoted strings

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Raised when one of the arguments is null |
| ArgumentOutOfRangeException | Raised if an argument contains '\0', '\r', or '\n' |

## See Also

* class [CommandLineTools](../CommandLineTools.md)