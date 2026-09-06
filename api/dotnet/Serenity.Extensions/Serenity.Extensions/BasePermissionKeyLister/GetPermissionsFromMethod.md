# BasePermissionKeyLister.GetPermissionsFromMethod method

Gets permissions from a method. Default implementation returns permissions from PermissionAttributeBase, PageAuthorizeAttribute and ServiceAuthorizeAttribute.

```csharp
protected virtual IEnumerable<string> GetPermissionsFromMethod(MethodInfo method)
```

| parameter | description |
| --- | --- |
| method |  |

## See Also

* class [BasePermissionKeyLister](../BasePermissionKeyLister.md)