# IAuthorizationService 接口

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

这是 Serenity 通过检查当前请求判断用户是否已登录的接口。 

```cs
public interface IAuthorizationService
{
    bool IsLoggedIn { get; }
    string Username { get; }
}
```

对于 web 应用程序的一些基本实现可能是：

```cs
using Serenity;
using Serenity.Abstractions;

public class MyAuthorizationService : IAuthorizationService
{
    public bool IsLoggedIn
    {
        get { return !string.IsNullOrEmpty(Username); }
    }

    public string Username
    {
        get { return WebSecurityHelper.HttpContextUsername; }
    }
}

/// ...

void Application_Start(object sender, EventArgs e)
{
	Dependency.Resolve<IDependencyRegistrar>()
		.RegisterInstance(new MyAuthorizationService());
}
```
