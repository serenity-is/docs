# IDependencyResolver Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

This interface defines the contract for dependency resolvers which are usually IoC containers that handles mapping between services and providers.

```cs
public interface IDependencyResolver
{
    TService Resolve<TService>() where TService : class;
    TService Resolve<TService>(string name) where TService : class;
    TService TryResolve<TService>() where TService : class;
    TService TryResolve<TService>(string name) where TService : class;
}
```

All methods are functionally equivalent to corresponding methods in Dependency static class.
