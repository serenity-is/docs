# TransientGrantingPermissionService.UndoGrant method

Reverts the most recent [`Grant`](./Grant.md) or [`GrantAll`](./GrantAll.md) operation.

```csharp
public void UndoGrant()
```

## Exceptions

| exception | condition |
| --- | --- |
| InvalidOperationException | The granting stack is empty. |

## See Also

* class [TransientGrantingPermissionService](../TransientGrantingPermissionService.md)