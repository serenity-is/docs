# Authentication &amp; Authorization

Serenity uses some abstractions to work with your application's own user authentication and authorization mechanism.

```cs
Serenity.Abstractions.IAuthenticationService
Serenity.Abstractions.IAuthorizationService
Serenity.Abstractions.IPermissionService
Serenity.Abstractions.IUserRetrieveService
```

As Serenity doesn't have default implementation for these abstractions, you should provide some implementation for them, using dependency registration system.

For example, Serenity Basic Application sample registers them in its SiteInitialization.ApplicationStart method like below:

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();

registrar.RegisterInstance<IAuthorizationService>(
	new Administration.AuthorizationService());

registrar.RegisterInstance<IAuthenticationService>(
	new Administration.AuthenticationService());

registrar.RegisterInstance<IPermissionService>(
	new Administration.PermissionService());

registrar.RegisterInstance<IUserRetrieveService>(
	new Administration.UserRetrieveService());
```

You might want to have a look at those sample implementations before writing your own.
