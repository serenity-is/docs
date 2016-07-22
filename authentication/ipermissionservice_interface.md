# IPermissionService 接口

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

权限（permission）是授权做一些操作（访问页面、调用指定服务）。在 Serenity 中，权限是一些分配给单个用户的字符串 keys（类似于 ASP.NET 角色）。

例如，如果一些用户有 `Administration` 权限，该用户可以看到该权限所能访问的导航连接或调用该权限所允许的服务。

> 你也可以使用像 `ApplicationID:PermissionID` （例如：`Orders:Create`）的复合访问许可键（permission keys），但是 Serenity 并不关心 ApplicationID 和 PermissionID，它只使用作为一个整体的复合访问许可键。


```cs
public interface IPermissionService
{
    bool HasPermission(string permission);
}
```

你可能有一个表……

```sql
CREATE TABLE UserPermissions (
	UserID int,
    Permission nvarchar(20)
}
```

然后查询该表以实现这个接口。

对于应用程序的简单示例，有一个唯一有 `Administration` 权限的 `admin` 用户：

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
