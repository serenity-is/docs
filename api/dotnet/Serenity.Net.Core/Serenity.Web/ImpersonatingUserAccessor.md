# ImpersonatingUserAccessor class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Adds impersonation support to any IUserContext implementation

```csharp
public class ImpersonatingUserAccessor : IImpersonator, IUserAccessor
```

| parameter | description |
| --- | --- |
| userContext | The user accessor service to wrap with impersonation support. |
| itemsAccessor | Request items accessor |

## Public Members

| name | description |
| --- | --- |
| [ImpersonatingUserAccessor](ImpersonatingUserAccessor/ImpersonatingUserAccessor.md)(…) | Adds impersonation support to any IUserContext implementation |
| [User](ImpersonatingUserAccessor/User.md) { get; } | Return current user |
| [Impersonate](ImpersonatingUserAccessor/Impersonate.md)(…) | Temporarily impersonates as a user |
| [UndoImpersonate](ImpersonatingUserAccessor/UndoImpersonate.md)() | Undoes impersonation |

## Remarks

Initializes a new instance of the [`ImpersonatingUserAccessor`](ImpersonatingUserAccessor.md) class that wraps passed authorization service and adds impersonation support.

## See Also

* interface [IImpersonator](../Serenity.Abstractions/IImpersonator.md)
* interface [IUserAccessor](../Serenity.Abstractions/IUserAccessor.md)
* **Source:** *[ImpersonatingUserAccessor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/ImpersonatingUserAccessor.cs)*