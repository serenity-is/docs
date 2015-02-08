# Authorization Static Class

[**namespace**: *Serenity*, **assembly**: *Serenity.Core*]

Authorization class provides some shortcuts to information which is provided by services like IAuthorizationService, IPermissionService etc.

For example, instead of writing
```cs
Dependency.Resolve<IAuthorizationService>().HasPermission("SomePermission")
```
you could use
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

`IsLoggedIn`, `UserDefinition`, `UserId`, `Username` and `HasPermission` make use of corresponding service for you to access information easier about current user.

`ValidateLoggedIn` checks if there is a logged user and if not, throws a `ValidationException` with error code `NotLoggedIn`.

`ValidatePermission` checks if logged user has specified permission and throws a `ValidationException` with error code `AccessDenied` otherwise.


