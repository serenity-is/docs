# Authentication &amp; Authorization

Serenity uses integrated authentication and authorization systems in ASP.NET Core, and provides some
additional abstractions to make it possible to work in environments other than web applications.

## IUserAccessor Interface

The current user in ASP.NET Core applications can be retrieved through HttpContext.User but accessing it directly 
would make Serenity tied to web applications only. To abstract this, and make Serenity also useful for console and desktop 
applications, we provide an 
[IUserAccessor](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/IUserAccessor.md) 
interface. The default implementation for this interface uses HttpContext.User in web applications but
can be implemented differently for other kinds of applications / tests.

## IPermissionService and IUserRetrieveService Abstractions

We also provide following abstractions for permission checking (authorization) and user detail retrieval.

* [IPermissionService](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/IPermissionService.md)
* [IUserRetrieveService](../api/dotnet/Serenity.Net.Core/Serenity.Abstractions/IUserRetrieveService.md)

As the framework itself doesn't have a default implementation for these abstractions, 
they should be provided in the application itself through dependency injection.

Serene / StartSharp applications have custom implementations and register them in Startup.cs:

```csharp
services.AddSingleton<IUserRetrieveService, Administration.UserRetrieveService>();
services.AddSingleton<IPermissionService, Administration.PermissionService>();
```

You may have a look at these sample implementations before writing your own.

## Authorization Attributes

In Serenity applications permissions control access to resources like navigation, pages and service calls.

Permissions can be assigned directly to users or indirectly through assigned roles which can also have a set of permissions.

To make it easy to validate permissions we provide some attributes in addition to the built-in `[Authorize]` attribute.

* [PageAuthorizeAttribute](../api/dotnet/Serenity.Net.Web/Serenity.Web/PageAuthorizeAttribute.md)
* [ServiceAuthorizeAttribute](../api/dotnet/Serenity.Net.Web/Serenity.Services/ServiceAuthorizeAttribute.md)

They have overloads that accepts a *permission* parameter which automatically validates that permission.

Difference between the two lies in the way they handle unauthenticated access attemps. While `[PageAuthorize]` attribute
throws an exception, `[ServiceAuthorize]` provides an AJAX call friendly service error.