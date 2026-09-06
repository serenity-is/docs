# BasePermissionKeyLister.GetPrivatePermissions method

Gets a list of permissions that are private and should not be listed. Default implementation returns ["ImpersonateAs"]

```csharp
protected virtual IEnumerable<string> GetPrivatePermissions()
```

## See Also

* class [BasePermissionKeyLister](../BasePermissionKeyLister.md)