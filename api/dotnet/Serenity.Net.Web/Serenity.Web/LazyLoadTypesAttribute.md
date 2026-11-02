# LazyLoadTypesAttribute class
**namespace:** *[Serenity.Web](../README.md#serenity.web-namespace)*   **assembly**: *[Serenity.Net.Web](../README.md)*

Declares the client side types implementing the `LazyLoadInclude` marker of corelib and the module that loads them, which is generated for a project that has such types. `Html.LazyTypes()` renders these for the default `Config.lazyTypeLoader`, which uses them to load a type when it is first requested from a type registry.

```csharp
[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
public class LazyLoadTypesAttribute : Attribute
```

| parameter | description |
| --- | --- |
| path | The app relative (`~/`) path of the module that exports the loaders of the types. |
| keys | The keys the types are registered with on the client side. |

## Public Members

| name | description |
| --- | --- |
| [LazyLoadTypesAttribute](LazyLoadTypesAttribute/LazyLoadTypesAttribute.md)(…) | Declares the client side types implementing the `LazyLoadInclude` marker of corelib and the module that loads them, which is generated for a project that has such types. `Html.LazyTypes()` renders these for the default `Config.lazyTypeLoader`, which uses them to load a type when it is first requested from a type registry. |
| [Keys](LazyLoadTypesAttribute/Keys.md) { get; } | Gets the keys the types are registered with on the client side. |
| [Path](LazyLoadTypesAttribute/Path.md) { get; } | Gets the app relative (`~/`) path of the module that exports the loaders of the types. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |

## See Also

* **Source:** *[LazyLoadTypesAttribute.cs](https://github.com/serenity-is/Serenity/blob/3ee4ed336eca3c73bc3d291124715a793a825afd/src/web/Mvc/Bundling/LazyLoadTypesAttribute.cs)*