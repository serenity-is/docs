# IAuthenticationService 接口

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

```cs
public interface IAuthenticationService
{
    bool Validate(ref string username, string password);
}
```

通常这是由登录页面调用检查输入的凭据是否正确的服务。如果用户名/密码正确，你的实现应该返回 true。 

模拟身份验证服务可以这样写：

```cs
public class DummyAuthenticationService : IAuthenticationService
{
    public bool Validate(ref string username, string password)
    {
        return username == password;
    }
}
```

如果用户名等于指定的密码（仅用于演示），则该服务返回 true。

第一个参数是含 ref 的参数，在登录之前，你可以把用户名修改为其在数据库中的实际表示形式。例如，用户可能在登录表单中输入大写的 `JOE`，但是实际上在数据库中的用户名是 `Joe`。这不是一项强制要求，但是如果你的数据库是大小写敏感的，可能在登录或登录后的过程中出现问题。 

你可以在  global.asax.cs / SiteInitialization.ApplicationStart 注册该服务，如：

```cs
protected void Application_Start(object sender, EventArgs e)
{
	Dependency.Resolve<IDependencyRegistrar>()
		.RegisterInstance(new DummyAuthenticationService());
}
```

并在你的登录表单中使用它：

```cs
void DoLogin(string username, string password)
{
	if (Dependency.Resolve<IAuthenticationService>()
			.Validate(ref username, password))
	{
		// FormsAuthentication.SetAuthenticationTicket etc.
	}
}
```
