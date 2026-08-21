# IImpersonator interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Defines a service that supports temporary user impersonation.

```csharp
public interface IImpersonator
```

## Members

| name | description |
| --- | --- |
| [Impersonate](IImpersonator/Impersonate.md)(…) | Temporarily impersonates the specified user. |
| [UndoImpersonate](IImpersonator/UndoImpersonate.md)() | Ends the most recent impersonation and restores the previous principal. |

## See Also

* **Source:** *[IImpersonator.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/IImpersonator.cs)*