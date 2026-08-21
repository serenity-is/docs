# ITransientGrantor interface
**namespace:** *[Serenity.Abstractions](../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../README.md)*

Defines a permission service that supports temporarily granting permissions.

```csharp
public interface ITransientGrantor
```

## Members

| name | description |
| --- | --- |
| [GetGranted](ITransientGrantor/GetGranted.md)() | Gets the permissions that were granted via [`Grant`](ITransientGrantor/Grant.md). |
| [Grant](ITransientGrantor/Grant.md)(…) | Temporarily grants the specified permissions. |
| [GrantAll](ITransientGrantor/GrantAll.md)() | Temporarily grants all permissions. |
| [IsAllGranted](ITransientGrantor/IsAllGranted.md)() | Determines whether all permissions are currently granted via [`GrantAll`](ITransientGrantor/GrantAll.md). |
| [UndoGrant](ITransientGrantor/UndoGrant.md)() | Reverts the most recent [`Grant`](ITransientGrantor/Grant.md) or [`GrantAll`](ITransientGrantor/GrantAll.md) operation. |

## See Also

* **Source:** *[ITransientGrantor.cs](https://github.com/serenity-is/Serenity/blob/master/src/Core/Authorization/ITransientGrantor.cs)*