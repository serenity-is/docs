# LazyLoadTypesAttribute constructor

Declares the client side types implementing the `LazyLoadInclude` marker of corelib and the module that loads them, which is generated for a project that has such types. `Html.LazyTypes()` renders these for the default `Config.lazyTypeLoader`, which uses them to load a type when it is first requested from a type registry.

```csharp
public LazyLoadTypesAttribute(string path, params string[] keys)
```

| parameter | description |
| --- | --- |
| path | The app relative (`~/`) path of the module that exports the loaders of the types. |
| keys | The keys the types are registered with on the client side. |

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | One of the arguments is `null`. |

## See Also

* class [LazyLoadTypesAttribute](../LazyLoadTypesAttribute.md)