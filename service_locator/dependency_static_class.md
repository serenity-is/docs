# 静态依赖类

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

依赖类是 Serenity 的服务定位器（service locator）。所有依赖都通过其方法进行查询：

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

在你应用程序的启动方法（如：global.asax.cs）中，你应该使用 SetResolver 方法设置依赖解析器（IDependencyResolver）的实现（IoC 容器）来初始化服务定位器。

# Dependency.SetResolver 方法

配置要使用的依赖解析器的实现。

你可以使用你喜欢的 IoC 容器，但 Serenity 已经包含了基于 Munq 的 IoC 容器：

```cs
var container = new MunqContainer();
Dependency.SetResolver(container);
```

SetResolver 方法返回之前配置的 IDependencyResolver 实现。如果之前没有配置，则返回 null。

# Dependency.Resolver 属性

返回当前配置的 IDependencyResolver 的实现。

如果尚未配置，则抛出 InvalidProgramException 异常。

# Depency.HasResolver 属性

如果 IDependencyResolver 的实现已通过 SetResolver 配置，则返回 true。否则，返回 false。

# Dependency.Resolve 方法

返回请求类型注册的实现。

如果被注册的类型尚未实现，则抛出 *KeyNotFoundException* 异常。

如果尚未配置依赖解析器，则抛出 *InvalidProgramException* 异常。

Resolve 方法的第二个重载接收一个 *name* 参数。如果不同提供者根据域（scope）为接口注册实现，就应使用这个重载方法。

例如，Serenity 有一个 IConfigurationRepository 接口，可以根据设置范围有不同的提供者。有些设置可能是 *应用程序* 范围（该应用程序的所有服务之间共享），而有些可能是 *服务* 范围（每个服务可能使用不同的唯一标识符）。

因此，要为这些范围的每个域注册 IConfigurationRepository 提供者，你应该像下面这样调用方法：

```cs
var appConfig = Dependency.Resolve<IConfigurationRepository>("Application");

var srvConfig = Dependency.Resolve<IConfigurationRepository>("Server");
```

# Dependency.TryResolve 方法

该方法在功能上与 Resolve 方法相同，只是使用不同的方式实现。

如果请求类型没有注册提供者，或依赖解析器尚未配置，TryResolve 不会引发异常，而是返回 null。
