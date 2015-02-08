# DistributedCacheEmulator Class
[**namespace**: *Serenity.Abstractions*, **assembly**: *Serenity.Core*]

If you don't need a distributed cache now, but you wanted to write code that will work with a distributed cache in the future, you could use the DistributedCacheEmulator class.

DistributedCacheEmulator is also useful for unit tests and development environments (so that developers don't need to access a distributed cache system and work without affecting each other).

DistributedCacheEmulator emulates the IDistributedCache interface in a thread-safe manner by using a in-memory dictionary.

To use DistributedCacheEmulator, you need to register it with the Serenity Service Locator (IDependencyRegistrar). We do it from some method called on application start (global.asax.cs etc):

```cs
private static void InitializeDependencies()
{
    // ...
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    registrar.RegisterInstance<IDistributedCache>(new DistributedCacheEmulator());
    // ...
}
```
