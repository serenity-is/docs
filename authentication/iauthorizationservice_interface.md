# IAuthorizationService Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

This is the interface that Serenity checks through to see if there is a logged user in current request.

```cs
public interface IAuthorizationService
{
    bool IsLoggedIn { get; }
    string Username { get; }
}
```

Some basic implementation for web applications could be:

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
