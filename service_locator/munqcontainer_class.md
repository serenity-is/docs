# MunqContainer Class

[**namespace**: *Serenity*, **assembly**: *Serenity.Core*]

Serenity includes a slightly modified version of Munq IoC container (http://munq.codeplex.com/).

MunqContainer class implements both IDependencyResolver and IDependencyRegistrar interfaces (all containers should).

Once you set a MunqContainer instance as dependency resolver like:

```cs
var container = new MunqContainer();
Dependency.SetResolver(container);
```

You can access its registration interface by querying for IDependencyRegistrar interface:

```cs
var registrar = Dependency.Resolve<IDependencyRegistrar>();
```

Here, *registrar* is the same MunqContainer instance (*container*) that we created in prior sample.

> If you would like to use another IoC container, you just have to create a class that implements IDependencyResolver and IDependencyRegistrar interfaces using your favorite IoC container.
