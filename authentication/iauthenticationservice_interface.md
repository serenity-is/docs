# IAuthenticationService Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

```cs
public interface IAuthenticationService
{
    bool Validate(ref string username, string password);
}
```

This is the service that you usually call from your login page to check if entered credentials are correct. Your implementation should return true if username/password pair matches.

A dummy authentication service could be written like this:

```cs
public class DummyAuthenticationService : IAuthenticationService
{
    public bool Validate(ref string username, string password)
    {
        return username == password;
    }
}
```

This service returns true, if username is equal to specified password (just for demo).

First parameter is passed by reference for you to change username to its actual representation in database before logging in. For example, the user might have entered uppercase `JOE` in login form, but actual username in database could be `Joe`.  This is not a requirement, but if your database is case sensitive, you might have problems during login or later phases.

You might register this service from global.asax.cs / SiteInitialization.ApplicationStart like:

```cs
protected void Application_Start(object sender, EventArgs e)
{
	Dependency.Resolve<IDependencyRegistrar>()
		.RegisterInstance(new DummyAuthenticationService());
}
```

And use it somewhere in your login form:

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
