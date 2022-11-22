# ServiceCollectionExtensions.AddJsonTexts method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds json texts from file provider and sub path

```csharp
public static ILocalTextRegistry AddJsonTexts(this ILocalTextRegistry registry, 
    IFileProvider provider, string subpath, bool recursive = true)
```

| parameter | description |
| --- | --- |
| registry | The text registry |
| provider | File provider |
| subpath | Sub path |
| recursive | True to recursively scan (default true) |

## Return Value

The text registry

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | registry, provider or sub path is null |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)