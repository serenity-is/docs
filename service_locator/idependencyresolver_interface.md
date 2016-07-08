# IDependencyResolver 接口

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

此接口通常定义依赖解析器（dependency resolvers）的契约，以使 IoC 容器处理服务（services）与提供者（providers）之间的映射。

```cs
public interface IDependencyResolver
{
    TService Resolve<TService>() where TService : class;
    TService Resolve<TService>(string name) where TService : class;
    TService TryResolve<TService>() where TService : class;
    TService TryResolve<TService>(string name) where TService : class;
}
```

所有方法在功能上都等于静态依赖类相应的方法。
