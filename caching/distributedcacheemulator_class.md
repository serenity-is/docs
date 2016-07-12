# DistributedCacheEmulator 类 

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

如果你现在不需要分布式缓存，但希望现在编写的代码在将来可以与分布式缓存一起工作，你可以使用 DistributedCacheEmulator 类。

DistributedCacheEmulator 也对单元测试和部署环境非常有用（因此，开发人员不需要访问分布式缓存系统而不会影响彼此的工作）。

DistributedCacheEmulator 模拟 IDistributedCache 接口以线程安全的方式使用内存中的字典。

要使用 DistributedCacheEmulator，需要使用 Serenity 服务定位器(IDependencyRegistrar)注册它。我们在应用程序启动时(global.asax.cs 等)调用一些方法做此事：

```cs
private static void InitializeDependencies()
{
    // ...
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    registrar.RegisterInstance<IDistributedCache>(new DistributedCacheEmulator());
    // ...
}
```
