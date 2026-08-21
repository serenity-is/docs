# ImpersonatingUserAccessor.UndoImpersonate method
**namespace:** *[Serenity.Web](../../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Pops the most recent impersonation from the stack.

```csharp
public void UndoImpersonate()
```

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | The impersonation stack is empty. |

## See Also

* class [ImpersonatingUserAccessor](../ImpersonatingUserAccessor.md)