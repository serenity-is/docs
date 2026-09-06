# ImpersonatingUserAccessor class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Wraps an [`IUserAccessor`](../Serenity.Abstractions/IUserAccessor.md) and adds support for temporary user impersonation.

```csharp
public class ImpersonatingUserAccessor : IImpersonator, IUserAccessor
```

| parameter | description |
| --- | --- |
| userContext | The underlying user accessor to delegate to when no impersonation is active. |
| itemsAccessor | The accessor that provides the per-request item dictionary used to store the impersonation stack. |

## Public Members

| name | description |
| --- | --- |
| [ImpersonatingUserAccessor](ImpersonatingUserAccessor/ImpersonatingUserAccessor.md)(…) | Wraps an [`IUserAccessor`](../Serenity.Abstractions/IUserAccessor.md) and adds support for temporary user impersonation. |
| [User](ImpersonatingUserAccessor/User.md) { get; } | Gets the current user principal, returning the top of the impersonation stack when impersonation is active. |
| [Impersonate](ImpersonatingUserAccessor/Impersonate.md)(…) | Pushes the specified principal onto the impersonation stack. |
| [UndoImpersonate](ImpersonatingUserAccessor/UndoImpersonate.md)() | Pops the most recent impersonation from the stack. |

## Remarks

Initializes a new instance of the [`ImpersonatingUserAccessor`](ImpersonatingUserAccessor.md) class that wraps the specified user accessor and adds impersonation support.

## See Also

* interface [IImpersonator](../Serenity.Abstractions/IImpersonator.md)
* interface [IUserAccessor](../Serenity.Abstractions/IUserAccessor.md)
* **Source:** *[ImpersonatingUserAccessor.cs](https://github.com/serenity-is/Serenity/blob/fa8ddd78cf707d00a1aca68d898e31e73d5971b9/src/core/Authorization/ImpersonatingUserAccessor.cs)*