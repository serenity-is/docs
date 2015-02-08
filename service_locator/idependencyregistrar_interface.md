# IDependencyRegistrar Interface

[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

Dependency resolvers should implement this interface (IDependencyRegistrar) to register dependencies:

```cs
public interface IDependencyRegistrar
{
    object RegisterInstance<TType>(TType instance) where TType : class;
    object RegisterInstance<TType>(string name, TType instance) where TType : class;
    object Register<TType, TImpl>() where TType : class where TImpl : class, TType;
    object Register<TType, TImpl>(string name) where TType : class where TImpl : class, TType;
    void Remove(object registration);
}
```

MunqContainer and other IoC containers are also dependency registrars (they implement IDependencyRegistrar interface), so you just have to query for it:

```cs
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    registrar.RegisterInstance<ILocalTextRegistry>(new LocalTextRegistry());
    registrar.RegisterInstance<IAuthenticationService>(...)
```

## IDependencyRegistrar.RegisterInstance Method

Registers a singleton instance of a type (TType, usually an interface) as provider of that type.

```cs
object RegisterInstance<TType>(TType instance) where TType : class;
```

When you register an object instance with this overload, whenever an implementation of `TType` is requested, the instance that you registered is returned from dependency resolver. This is similar to *Singleton Pattern*.

```cs
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    registrar.RegisterInstance<ILocalTextRegistry>(new LocalTextRegistry());
```

> If there was already a registration for TType, it is overridden.

This overload is the most used method of registering dependencies.

> Make sure the provider which you registered is thread safe, as all threads will be using your instance at same time!

RegisterInstance has a less commonly used overload with a *name* parameter:

```
object RegisterInstance<TType>(string name, TType instance) where TType : class;
```

Using this overload, you can register different providers for the same interface, differentiated by a string key.

For example, Serenity has a IConfigurationRepository interface that can have different providers based on setting scope. Some settings might be *Application* scoped (shared between all servers for this application), while some might be *Server* scoped (each server might use a different unique identifier).

So, to register a IConfigurationRepository provider for each of these scopes, you would call the method like:

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();

registrar.RegisterInstance<IConfigurationRepository>(
    "Application", new MyApplicationConfigurationRepository());

registrar.RegisterInstance<IConfigurationRepository>(
    "Server", new MyServerConfigurationRepository());
```

And when querying for these dependencies:

```cs
var appConfig = Dependency.Resolve<IConfigurationRepository>("Application");
// ...
var srvConfig = Dependency.Resolve<IConfigurationRepository>("Server");
// ...
```

## IDependencyRegistrar.Register Method

Unlike *RegisterInstance*, when a type is registered with this method, every time a provider for that type is requested, a new instance will be returned (so each requestor gets a unique instance).

```cs
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    registrar.Register<ILocalTextRegistry, LocalTextRegistry>();
```

## IDependencyRegistrar.Remove Method

All registration methods of IDependencyRegistrar interface returns an object which you can later use to remove that registration.

Avoid using this method in ordinary applications as all registrations should be done from a central location and once per lifetime of the application. But this can be useful for unit test purposes.

```cs
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    var registration = registrar.Register<ILocalTextRegistry, LocalTextRegistry>();
    //...
    registrar.Remove(registration);
```

> This is not an undo operation. If you register type C for interface A, while type B was already registered for the same interface, prior registration is overriden and lost. You can't get back to prior state by removing registration of C.
