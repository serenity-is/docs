# 静态 Authorization 类 

[**命名空间**: *Serenity*, **程序集**: *Serenity.Core*]

Authorization 类提供一些像 IAuthorizationService、IPermissionService 等服务提供的信息的捷径。

例如，要替换下面的写法
```cs
Dependency.Resolve<IAuthorizationService>().HasPermission("SomePermission")
```
你可以使用 
```cs
Authorization.HasPermission("SomePermission")
```

```cs
public static class Authorization
{
    public static bool IsLoggedIn { get; }
    public static IUserDefinition UserDefinition { get; }
    public static string UserId { get; }
    public static string Username { get; }
    public static bool HasPermission(string permission);
    public static void ValidateLoggedIn();
    public static void ValidatePermission(string permission);
}
```

`IsLoggedIn`、 `UserDefinition`、 `UserId`、 `Username` 和 `HasPermission` 是为了让使用对应服务访问当前用户信息更容易。

`ValidateLoggedIn` 检查是否有登录用户，如果没有登录用户，则抛出含错误码 `NotLoggedIn` 的 `ValidationException` 异常。

`ValidatePermission` 检查登录用户是否有指定的权限，如果没有相应权限，则抛出含错误码 `AccessDenied` 的 `ValidationException` 异常。 


