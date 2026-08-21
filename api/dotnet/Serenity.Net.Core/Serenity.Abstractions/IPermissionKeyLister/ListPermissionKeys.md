# IPermissionKeyLister.ListPermissionKeys method
**namespace:** *[Serenity.Abstractions](../../README.md#serenity.abstractions-namespace)*   **assembly**: *[Serenity.Net.Core](../../README.md)*

Lists all permission keys.

```csharp
public IEnumerable<string> ListPermissionKeys(bool includeRoles)
```

| parameter | description |
| --- | --- |
| includeRoles | When `true`, includes role-derived keys such as `Role:SomeRole`. |

## Return Value

An enumerable of permission keys.

## See Also

* interface [IPermissionKeyLister](../IPermissionKeyLister.md)