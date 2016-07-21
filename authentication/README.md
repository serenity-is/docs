# 认证 &amp; 授权

Serenity 使用一些抽象（abstractions）来与你的应用程序自身的用户身份验证和授权机制一起工作。

```cs
Serenity.Abstractions.IAuthenticationService
Serenity.Abstractions.IAuthorizationService
Serenity.Abstractions.IPermissionService
Serenity.Abstractions.IUserRetrieveService
```

由于 Serenity 没有为这三个抽象提供默认实现，你应该使用依赖注册系统为它们提供一些实现。

例如，Serenity 基本应用程序示例在其 SiteInitialization.ApplicationStart 方法注册权限，如：

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

在编写你自己的权限之前，你可能需要看看这些示例的实现。
