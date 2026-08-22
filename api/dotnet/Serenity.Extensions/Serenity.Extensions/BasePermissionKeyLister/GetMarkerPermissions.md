# BasePermissionKeyLister.GetMarkerPermissions method
**namespace:** *[Serenity.Extensions](../../README.md#serenity.extensions-namespace)*   **assembly**: *[Serenity.Extensions](../../README.md)*

Gets a list of permissions that are used as markers and should not be listed. Default implementation returns ["*", "?", "DENY"]

```csharp
protected virtual IEnumerable<string> GetMarkerPermissions()
```

## See Also

* class [BasePermissionKeyLister](../BasePermissionKeyLister.md)