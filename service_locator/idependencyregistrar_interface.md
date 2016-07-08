# IDependencyRegistrar 接口

[**命名空间**: *Serenity.Abstractions*, **程序集**: *Serenity.Core*]

依赖解析器（Dependency resolvers）应该实现 IDependencyRegistrar 接口来注册依赖：

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

MunqContainer 和其他 IoC 容器同样依赖注册（他们都实现 IDependencyRegistrar 接口），所以你只需对它查询：

```cs
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    registrar.RegisterInstance<ILocalTextRegistry>(new LocalTextRegistry());
    registrar.RegisterInstance<IAuthenticationService>(...)
```

## IDependencyRegistrar.RegisterInstance 方法

注册器（Registers）是一个类型（TType，通常是一个接口）的单例，作为该类型的提供者。

```cs
object RegisterInstance<TType>(TType instance) where TType : class;
```

当你使用该重载方法注册一个对象实例，每当请求 `TType` 的实例时，会从依赖解析器返回你注册的该实例。这类似于 *单例模式*。

```cs
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    registrar.RegisterInstance<ILocalTextRegistry>(new LocalTextRegistry());
```

> 如果已经有 TType 的注册，它将被重写。

此重载是注册依赖最常用的方法。

> 确保注册的提供者是线程安全的，因为所有线程将在同一时间使用该实例。

RegisterInstance 有一个不太常用的含 *name* 参数的重载：

```
object RegisterInstance<TType>(string name, TType instance) where TType : class;
```

使用该重载，你可以为同一接口通过不同的字符串标识（string key）注册不同的提供者。

例如，Serenity 有一个 IConfigurationRepository 接口，可以根据设置范围有不同的提供者。有些设置可能是 *应用程序* 范围（该应用程序的所有服务之间共享），而有些可能是 *服务* 范围（每个服务可能使用不同的唯一标识符）。

因此，要为这些范围的每个域注册 IConfigurationRepository 提供者，你应该像下面这样调用方法：

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();

registrar.RegisterInstance<IConfigurationRepository>(
    "Application", new MyApplicationConfigurationRepository());

registrar.RegisterInstance<IConfigurationRepository>(
    "Server", new MyServerConfigurationRepository());
```

当查询这些依赖时：

```cs
var appConfig = Dependency.Resolve<IConfigurationRepository>("Application");
// ...
var srvConfig = Dependency.Resolve<IConfigurationRepository>("Server");
// ...
```

## IDependencyRegistrar.Register 方法 

不像 *RegisterInstance*，当一个类型使用这种方式注册时，每次请求该类型的提供者都会返回一个新的实例（所以每个请求获得一个唯一的实例）。

```cs
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    registrar.Register<ILocalTextRegistry, LocalTextRegistry>();
```

## IDependencyRegistrar.Remove 方法

所有 IDependencyRegistrar 接口的注册方法返回一个对象，你可以在以后使用该对象删除此注册。

在普通应用程序中应该避免使用这个方法，因为所有的注册应该在一个集中的位置进行，并且在应用程序的生命周期中只注册一次。但是，该方法可能对单元测试非常有用。

```cs
    var registrar = Dependency.Resolve<IDependencyRegistrar>();
    var registration = registrar.Register<ILocalTextRegistry, LocalTextRegistry>();
    //...
    registrar.Remove(registration);
```

> 这不是撤消操作。如果你为接口 A 注册类型 C，而类型 B 已经注册了同一个接口，先前的注册会被重写且被丢失。你不能通过删除注册 C 找回以前的状态。
