# ServiceCollectionExtensions.AddBaseTexts method
**namespace:** *[Serenity.Extensions.DependencyInjection](../../README.md#serenity.extensions.dependencyinjection-namespace)*   **assembly**: *[Serenity.Net.Services](../../README.md)*

Adds nested texts, enum texts, permission texts, row texts and json local text assets

```csharp
public static ILocalTextRegistry AddBaseTexts(this IServiceProvider provider, 
    IFileProvider webFileProvider)
```

| parameter | description |
| --- | --- |
| provider | The service provider that will be used to locate text registry and other types |
| webFileProvider | If passed, json texts from static web assets will be added from Serenity.Scripts, and any assembly with a JsonLocalTextAssetsAttribute attribute |

## Return Value

Local text registry

## Exceptions

| exception | condition |
| --- | --- |
| ArgumentNullException | Provider is null |

## See Also

* interface [ILocalTextRegistry](../Serenity.Net.Core/../../Serenity.Abstractions/ILocalTextRegistry.md)
* class [ServiceCollectionExtensions](../ServiceCollectionExtensions.md)