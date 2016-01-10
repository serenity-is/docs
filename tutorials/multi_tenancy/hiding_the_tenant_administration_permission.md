# Hiding the Tenant Administration Permission

We now have one little problem. User *tenant2* has permission *Administration:Security* so he can access user and role permission dialogs. Thus, he can grant himself *Administration:Tenants* permission using the permission UI.

![Tenant2 Granting Himself](img/tenant2_granting_tenants.png)

Serenity scans your assemblies for attributes like *ReadPermission*, *WritePermission*, *PageAuthorize*, *ServiceAuthorize* etc. and lists these permissions in edit permissions dialog.

We should first remove it from this pre-populated list.

Find method, *ListPermissionKeys* in *UserPermissionRepository.cs*:

```
public ListResponse<string> ListPermissionKeys()
{
    return LocalCache.Get("Administration:PermissionKeys", TimeSpan.Zero, () =>
    {
        //...

        result.Remove(Administration.PermissionKeys.Tenants);
        result.Remove("*");
        result.Remove("?");
        
        //...
```

