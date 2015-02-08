# Dependency Static Class

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

Dependency class is the service locator of Serenity. All dependencies are queried through its methods:

```cs
public static class Dependency
{
    public static TType Resolve<TType>() where TType : class;
    public static TType Resolve<TType>(string name) where TType : class;
    public static TType TryResolve<TType>() where TType : class;
    public static TType TryResolve<TType>(string name) where TType : class;

    public static IDependencyResolver SetResolver(IDependencyResolver value);
    public static IDependencyResolver Resolver { get; }
    public static bool HasResolver { get; }
}
```

In your application's start method (e.g. in global.asax.cs) you should initialize service locator by setting a dependency resolver (IDependencyResolver) implementation (an IoC container) with SetResolver method.

# Dependency.SetResolver Method

Configures the dependency resolver implementation to use.

You can use IoC container of your choice but Serenity already includes one based on Munq:

```cs
var container = new MunqContainer();
Dependency.SetResolver(container);
```

SetResolver methods return previously configured IDependencyResolver implementation, or null if none is configured before.

# Dependency.Resolver Property

Returns currently configured IDependencyResolver implementation.

Throws a InvalidProgramException if none is configured yet.

# Depency.HasResolver Property

Returns true if a IDependencyResolver implementation is configured through SetResolver. Returns false, if not.

# Dependency.Resolve Method

Returns the registered implementation for requested type.

If no implementation is registered, throws a *KeyNotFoundException*.

If no dependency resolver is configured yet, throw a *InvalidProgramException*

Second overload of Resolve method accepts a *name* parameter. This should be used if different providers are registered for an interface depending on scope.

For example, Serenity has a IConfigurationRepository interface that can have different providers based on setting scope. Some settings might be *Application* scoped (shared between all servers for this application), while some might be *Server* scoped (each server might use a different unique identifier).

So, to retrieve a IConfigurationRepository provider for each of these scopes, you would call the method like:

```cs
var appConfig = Dependency.Resolve<IConfigurationRepository>("Application");

var srvConfig = Dependency.Resolve<IConfigurationRepository>("Server");
```

# Dependency.TryResolve Method

This is functionally equivalent to Resolve method with one difference.

If a provider is not registered for requested type, or no dependency resolver is configured yet, TryResolve doesn't throw an exception, but instead returns null.
