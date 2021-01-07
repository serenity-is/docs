# ImpersonatingUserAccessor class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds impersonation support to any IUserContext implementation

```csharp
public class ImpersonatingUserAccessor : IImpersonator, IUserAccessor
```

## Public Members

| name | description |
| --- | --- |
| [ImpersonatingUserAccessor](ImpersonatingUserAccessor/ImpersonatingUserAccessor.md)(…) | Initializes a new instance of the [`ImpersonatingUserAccessor`](ImpersonatingUserAccessor.md) class that wraps passed authorization service and adds impersonation support. |
| [User](ImpersonatingUserAccessor/User.md) { get; } | Return current user |
| [Impersonate](ImpersonatingUserAccessor/Impersonate.md)(…) | Temporarily impersonates as a user |
| [UndoImpersonate](ImpersonatingUserAccessor/UndoImpersonate.md)() | Undoes impersonation |

## See Also

* interface [IImpersonator](../Serenity.Abstractions/IImpersonator.md)
* interface [IUserAccessor](../Serenity.Abstractions/IUserAccessor.md)
* **Source:** *[ImpersonatingUserAccessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Serenity.Net.Core/Authorization/ImpersonatingUserAccessor.cs)*