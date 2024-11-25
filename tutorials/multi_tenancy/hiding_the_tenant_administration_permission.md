# Hiding the Tenant Administration Permission

There is a security risk where user _tenant2_ possesses the *Administration:Security* permission, granting access to user and role permission dialogs. Consequently, _tenant2_ can assign the *Administration:Tenants* permission to their own user account through the permission UI.

![ _Tenant2_  Granting Himself](img/tenant2_granting_tenants.png)

Serenity scans your assemblies for attributes such as *ReadPermission*, *WritePermission*, *PageAuthorize*, and *ServiceAuthorize*, and displays these permissions in the edit permissions dialog. We should begin by removing it from the pre-populated list.

Modify the `PermissionKeyLister.cs` file as demonstrated below:

```
using MovieTutorial.Administration;

namespace MovieTutorial.AppServices;
public class PermissionKeyLister(ITwoLevelCache cache, ITypeSource typeSource)
    : BasePermissionKeyLister(cache, typeSource)
{
    protected override string GetCacheGroupKey()
    {
        return RoleRow.Fields.GenerationKey;
    }

    protected override IEnumerable<string> GetPrivatePermissions()
    {
        return [
            .. base.GetPrivatePermissions(),
            PermissionKeys.Tenants
        ];
    }
}
```

As a result, this permission will no longer appear in the *Edit User Permissions* or *Edit Role Permissions* dialogs.

However, the user could still assign this permission to themselves by manipulating the *UserPermissionRepository.Update* or *RolePermissionRepository.Update* methods.

To mitigate this, we should implement additional checks:


```cs
public class UserPermissionRepository : BaseRepository
{
    private readonly IPermissionKeyLister permissionKeyLister;

    public UserPermissionRepository(IRequestContext context, IPermissionKeyLister permissionKeyLister)
         : base(context)
    {
        this.permissionKeyLister = permissionKeyLister ?? throw new ArgumentNullException(nameof(permissionKeyLister));
    }

    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }

    public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request)
    {
        //...

        var newList = new Dictionary<string, bool>(StringComparer.OrdinalIgnoreCase);
        foreach (var p in request.Permissions)
            newList[p.PermissionKey] = p.Granted ?? false;

        var allowedKeys = this.permissionKeyLister.ListPermissionKeys(true);
        if (newList.Keys.Any(x => !allowedKeys.Contains(x)))
            throw new AccessViolationException();
        //...

```

```cs
public class RolePermissionRepository : BaseRepository
{
    private readonly IPermissionKeyLister permissionKeyLister;

    public RolePermissionRepository(IRequestContext context, IPermissionKeyLister permissionKeyLister)
         : base(context)
    {
        this.permissionKeyLister = permissionKeyLister ?? throw new ArgumentNullException(nameof(permissionKeyLister));
    }

    private static MyRow.RowFields Fld { get { return MyRow.Fields; } }

    public SaveResponse Update(IUnitOfWork uow, RolePermissionUpdateRequest request)
    {
        //...

        var newList = new HashSet<string>(request.Permissions.ToList(),
            StringComparer.OrdinalIgnoreCase);

        var allowedKeys = this.permissionKeyLister.ListPermissionKeys(true);
        if (newList.Any(x => !allowedKeys.Contains(x)))
            throw new AccessViolationException();
        //...
```

This implementation verifies whether any new permission keys being granted are absent from the permissions dialog. If such keys are detected, it likely indicates an unauthorized manipulation attempt.

> This verification should be standard practice even in single-tenant systems, but usually administrative users are typically trusted. However, in this context, where administrators are limited to managing their respective tenants, enforcing this check is essential.

After adding the new `IPermissionKeyLister` interface to the constructor, it is necessary to update the endpoints to inject the `IPermissionKeyLister` into the relevant repositories.

`RolePermissionEndpoint.cs`:

```cs
using MyRepository = MovieTutorial.Administration.Repositories.RolePermissionRepository;
using MyRow = MovieTutorial.Administration.RolePermissionRow;

namespace MovieTutorial.Administration.Endpoints;
[Route("Services/Administration/RolePermission/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class RolePermissionEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, RolePermissionUpdateRequest request,
        [FromServices] IPermissionKeyLister permissionKeyLister)
    {
        return new MyRepository(Context, permissionKeyLister).Update(uow, request);
    }

    public RolePermissionListResponse List(IDbConnection connection, RolePermissionListRequest request,
        [FromServices] IPermissionKeyLister permissionKeyLister)
    {
        return new MyRepository(Context, permissionKeyLister).List(connection, request);
    }
}
```

`UserPermissionEndpoint.cs`:

```cs
using MyRepository = MovieTutorial.Administration.Repositories.UserPermissionRepository;
using MyRow = MovieTutorial.Administration.UserPermissionRow;

namespace MovieTutorial.Administration.Endpoints;
[Route("Services/Administration/UserPermission/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class UserPermissionEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, UserPermissionUpdateRequest request,
        [FromServices] IPermissionKeyLister permissionKeyLister)
    {
        return new MyRepository(Context, permissionKeyLister).Update(uow, request);
    }

    public ListResponse<MyRow> List(IDbConnection connection, UserPermissionListRequest request,
        [FromServices] IPermissionKeyLister permissionKeyLister)
    {
        return new MyRepository(Context, permissionKeyLister).List(connection, request);
    }

    public ListResponse<string> ListRolePermissions(IDbConnection connection, UserPermissionListRequest request,
        [FromServices] IPermissionKeyLister permissionKeyLister)
    {
        return new MyRepository(Context, permissionKeyLister).ListRolePermissions(connection, request);
    }

    public ListResponse<string> ListPermissionKeys(
        [FromServices] IPermissionKeyLister permissionKeyLister)
    {
        return new ListResponse<string>
        {
            Entities = permissionKeyLister.ListPermissionKeys(includeRoles: false).ToList()
        };
    }
}
```