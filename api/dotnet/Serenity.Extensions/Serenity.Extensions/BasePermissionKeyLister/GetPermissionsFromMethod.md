# BasePermissionKeyLister.GetPermissionsFromMethod method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Gets permissions from a method. Default implementation returns permissions from PermissionAttributeBase, PageAuthorizeAttribute and ServiceAuthorizeAttribute.

```csharp
protected virtual IEnumerable<string> GetPermissionsFromMethod(MethodInfo method)
```

| parameter | description |
| --- | --- |
| method |  |

## See Also

* class [BasePermissionKeyLister](../BasePermissionKeyLister.md)