# IPermissionService Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

A permission is some grant to do some action (entering a page, calling a certain service). In Serenity permissions are some string keys that are assigned to individual users (similar to ASP.NET roles).

For example, if we say some user has `Administration` permission, this user can see navigation links that requires this permission or call services that require the same.

> You can also use composite permission keys like `ApplicationID:PermissionID` (for example `Orders:Create`), but Serenity doesn't care about application ID, nor permission ID, it only uses the composite permission key as a whole.


```cs
public interface IPermissionService
{
    bool HasPermission(string permission);
}
```

You might have a table like...

```sql
CREATE TABLE UserPermissions (
	UserID int,
    Permission nvarchar(20)
}
```

and query on this table to implement this interface.

A simpler sample for applications where there is a `admin` user who is the only one that has the permission `Administration` could be:

```cs
using Serenity;
using Serenity.Abstractions;

public class DummyPermissionService : IPermissionService
{
    public bool HasPermission(string permission)
    {
        if (Authorization.Username == "admin")
            return true;

        if (permission == "Administration")
            return false;

        return true;
    }
}
```
