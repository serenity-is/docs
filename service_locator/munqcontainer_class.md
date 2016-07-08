# MunqContainer 类 

[**命名空间**: *Serenity*, **程序集**: *Serenity.Core*]

Serenity 包括稍加修改的 Munq IoC 容器（http://munq.codeplex.com/）。

MunqContainer 类实现  IDependencyResolver 和 IDependencyRegistrar 接口（所有容器都应该实现这两个接口）。 

一旦你像下面这样设置 MunqContainer 实例作为依赖解析器（dependency resolver）：

```cs
var container = new MunqContainer();
Dependency.SetResolver(container);
```

你就可以通过查询 IDependencyRegistrar 接口访问其注册接口：

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();
```

在这里，*registrar* 是我们在先前示例中创建的相同 MunqContainer 实例（*容器*）。

> 如果你想使用其他的 IoC 容器，你只需创建一个的类，使用你最喜欢的 IoC 容器实现 IDependencyResolver 和 IDependencyRegistrar 接口。
